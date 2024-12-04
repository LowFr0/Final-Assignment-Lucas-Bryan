using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float TimeLeft = 120.0f;
    private bool TimerOn = false;
    public GameEnding gameEnding;

    void Start()
    {
        TimerOn = true;
    }

    void Update()
    {
        if (TimeLeft > 0)
        {
            TimeLeft -= Time.deltaTime;
        }
        else if (TimeLeft < 0)
        {
            TimeLeft = 0;
            gameEnding.CaughtPlayer ();
            Destroy(gameObject);
        }
        
        int minutes = Mathf.FloorToInt(TimeLeft / 60);
        int seconds = Mathf.FloorToInt(TimeLeft % 60);
        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);

    }
}
