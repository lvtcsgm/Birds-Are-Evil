using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrenchDuckMove : MonoBehaviour
{
    public float speed;
    public GameObject player;

    Vector3 player_pos;
    Vector3 destination;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10.0f;
        // get the position of the player
        player_pos = player.transform.position;
        // vector 2d math --> subtract the two positions to get the vector between them
        destination = player_pos - gameObject.transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
 
        rb.AddForce(destination * Time.deltaTime * speed);
    }

    
}
