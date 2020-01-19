using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructie_Behaviors : MonoBehaviour
    
{
    Vector3 player_pos;
    Vector3 destination;
    Rigidbody2D rb;
    public GameObject player;
    public GameObject Offscreen;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        player_pos = player.transform.position;
        destination = player_pos - gameObject.transform.position;
        rb = GetComponent<Rigidbody2D>();
    }
    void DestroyPosers()
    {
        GameObject[] ducks;
        ducks = GameObject.FindGameObjectsWithTag("Clone");
        foreach (GameObject duck in ducks)
        {
            Destroy(duck);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(destination * Time.deltaTime * moveSpeed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null && collision.gameObject.tag == "Player")
        {
            player.transform.position = Offscreen.transform.position;
            DestroyPosers();

        }
        
    }

    
}
