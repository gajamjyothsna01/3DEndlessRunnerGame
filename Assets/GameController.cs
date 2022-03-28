using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This Script to control Camera and pLAYER.
public class GameController : MonoBehaviour
{
    public GameObject playerMovement;
    public Camera cam;
    public float safeMargin;
    public Vector3 offset;
    public GameObject[] platformPrefab;
    GameObject tempBlock;
    public float spawnPoint = 0f;
    //public GameObject currentPlatform;
    // Start is called before the first frame update
    void Start()
    {
       
      // int k = Random.Range(0, platformPrefab.Length);
      
        //Instantiate(platformPrefab[1], tempBlock.transform.position + new Vector3(10f, 0f, 0f), Quaternion.identity);
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
       while(spawnPoint < playerMovement.transform.position.x + safeMargin)
        {
            int k = Random.Range(0, platformPrefab.Length);
            if(spawnPoint < 10)
            {
                k = 0;
            }
            GameObject  currentPlatform = Instantiate(platformPrefab[k], transform.position, Quaternion.identity);
            PlatformController platformController = currentPlatform.GetComponent<PlatformController>();
           // Debug.Log(platformController.platformSize);
            currentPlatform.transform.position = new Vector3(spawnPoint+platformController.transform.localScale.x/2,0,0);
           spawnPoint = spawnPoint + platformController.transform.localScale.x;
          //  spawnPoint = spawnPoint + platformController.platformSize / 2;
        }


    }
}
