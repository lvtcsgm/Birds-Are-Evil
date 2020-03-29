using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destructie_Behaviors : MonoBehaviour
    
{
    Vector3 player_pos;
    Vector3 destination;
    Rigidbody2D rb;
    public GameObject player;
    public GameObject Offscreen;
    public float moveSpeed;
    private Spawner spawner;
    public Timer timersss;
    public LevelManager managersss;

    // Start is called before the first frame update
    void Start()
    {
        player_pos = player.transform.position;
        destination = player_pos - gameObject.transform.position;
        Debug.Log(destination);
        rb = GetComponent<Rigidbody2D>();
        spawner = FindObjectOfType<Spawner>();
        if (spawner == null)
        {
            Debug.Log("Spawner is null");
        }
        if (gameObject.tag == "EducK")
        {
            moveSpeed = 0;
        }
        else
        {
            moveSpeed = 10;
        }
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
            spawner.stopSpawning();
            player.transform.position = Offscreen.transform.position;
            timersss.StopTimer();
            DestroyPosers();
            managersss.LoadLevel("PLay Again");
            Savesss.Highscoreee = timersss.GetTime();
            

        }
        
    }

    
}
