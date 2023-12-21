using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float seconds;
    private TMP_Text timer;
    void Awake()
    {
        timer = GetComponent<TMP_Text>();
        seconds = 60f;
        timer.text = "Seconds: " + seconds;
    }

    // Update is called once per frame
    void Update()
    {
        if((int)seconds == 0)
        {
            Debug.Log("You lose");
        }
        else
        {
            seconds -= Time.deltaTime;
            timer.text = "Seconds: " + (int)seconds;
        }
    }
}
