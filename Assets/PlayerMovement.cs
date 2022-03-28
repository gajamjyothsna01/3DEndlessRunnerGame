using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float playerJumpForce;
   // float inputX;
    Rigidbody rb;
    public float playerSpeed;
    bool isGrounded = true;
    int score;
    public Text scoreText;
    int speedToIncrease, increaseTheSpeedAfterSomeDistance;
    public Text textScore;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& isGrounded == true)
        {
            rb.AddForce(Vector3.up * playerJumpForce);
            isGrounded = false;
        }
        score = Mathf.FloorToInt(transform.position.x);
        scoreText.text = score.ToString();
        if (score == speedToIncrease)
        {
            playerSpeed = playerSpeed + 0.5f;
            speedToIncrease = speedToIncrease + increaseTheSpeedAfterSomeDistance;
        }


        //  Debug.Log(score);   

    }
    private void FixedUpdate()
    {
       // inputX = Input.GetAxis("Horizontal");
        
        rb.velocity = new Vector3(playerSpeed , rb.velocity.y, rb.velocity.z );


    }
    private void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.tag == "Ground")
        {
            isGrounded =true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<ObstacleController>()!=null)
        {
            Destroy(this.gameObject);
           // Destroy(other.gameObject);
        }
    }

}
