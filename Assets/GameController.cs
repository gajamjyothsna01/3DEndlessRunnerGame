using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This Script to control Camera and pLAYER.
public class GameController : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public Camera cam;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //When player exists
      
        if(playerMovement!=null)
        {
            cam.transform.position = new Vector3(playerMovement.transform.position.x, cam.transform.position.y, cam.transform.position.z);
            //cam.transform.position = new Vector3(playerMovement.transform.position.x, cam.transform.position.y, cam.transform.po
        }
        
    }
}
