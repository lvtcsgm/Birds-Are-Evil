using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int movementspeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePenguin();
       
    }
    void MovePenguin()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.position.y < 5.2)
            {
                transform.Translate(Vector3.up * movementspeed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.position.y > -5.2)
            {
                transform.Translate(Vector3.down * movementspeed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > -10.8)
            {
                transform.Translate(Vector3.left * movementspeed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < 10.8)
            {
                transform.Translate(Vector3.right * movementspeed * Time.deltaTime);
            }
        }
    }
   
}
