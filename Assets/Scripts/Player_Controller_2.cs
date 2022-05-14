using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller_2 : MonoBehaviour
{
    private float horizontalInput;
    private float speed= 10.0f;
    private float inBoundsRight = 8.0f;
    private float inBoundsLeft = -8.0f;
    public GameObject projectilePrefab;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
       horizontalInput = Input.GetAxis("Horizontal"); 
       // bu kod da çalışıyor
       // transform.Translate(horizontalInput,0,0);
       transform.Translate(Vector3.right*horizontalInput*Time.deltaTime*speed);
       
       
       // Inbounds script
       
       if (transform.position.x > inBoundsRight)
       {
           transform.position = new Vector3(inBoundsRight, transform.position.y, transform.position.z); 
       }
       
       if (transform.position.x < inBoundsLeft)
       {
           transform.position = new Vector3(inBoundsLeft, transform.position.y, transform.position.z); 
       }
       
       // Projectile Script 

       if (Input.GetKeyDown(KeyCode.Space))
       {

           Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
           
       }
       
       

    }
}
