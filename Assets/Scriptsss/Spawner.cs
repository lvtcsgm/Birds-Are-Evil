using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameObject EvilFrenchDuck;
    public GameObject Penguin;
    public int pasttime;
    public int presenttime;
    public int theweirdspaceinbetween;
    public Text stopwatch;
    // Start is called before the first frame update
    void Start()
    {
        SpawnOnEdge();
        GameOver();
        pasttime = (int)Time.time;
        InvokeRepeating("SpawnOnEdge", 0.5f, 0.3f);

    }

    // Update is called once per frame
    void Update()
    {
        //   SpawnOnEdge();
        GameOver();
        UpdateTimer();

    }
    void SpawnOnEdge()
    {
        GameObject tempDuck;

        int direction = Random.Range(0, 4);
        // Spawn on bottom
        if (direction == 0)
        {
            tempDuck = Instantiate(EvilFrenchDuck, new Vector3(Random.Range(-10.8f, 10.8f), -5.2f, 0), Quaternion.identity);
            tempDuck.tag = "Clone";
        }
        // left
        else if (direction == 1)
        {
            tempDuck = Instantiate(EvilFrenchDuck, new Vector3(-10.8f, Random.Range(-5.2f, 5.2f), 0), Quaternion.identity);
            tempDuck.tag = "Clone";
        }
        //right
        else if (direction == 2)
        {
            tempDuck = Instantiate(EvilFrenchDuck, new Vector3(10.8f, Random.Range(-5.2f, 5.2f), 0), Quaternion.identity);
            tempDuck.tag = "Clone";
        }
        //top
        else if (direction == 3)
        {
            tempDuck = Instantiate(EvilFrenchDuck, new Vector3(Random.Range(-10.8f, 10.8f), 5.2f, 0), Quaternion.identity);
            tempDuck.tag = "Clone";
        }

    }
    void GameOver()
    {
        if (Penguin == null)
        {
            Debug.Log("Game Over (*cough* loser)");

        }
    }

    void UpdateTimer()
    {
        presenttime = (int)Time.time;
        theweirdspaceinbetween = presenttime - pasttime;
        Debug.Log(theweirdspaceinbetween);
        stopwatch.text = "Time: " + theweirdspaceinbetween;
    }
    public void stopSpawning()
    {
        CancelInvoke("SpawnOnEdge");
    }
}
