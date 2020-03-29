using UnityEngine;
using UnityEngine.UI;


public class TimeDisplay : MonoBehaviour
{
    private Timer timer;
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        timer = FindObjectOfType<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = timer.GetTime().ToString("0.0");

    }

    public void ResetTime()
    {
        text.text = "0";

    }
}
