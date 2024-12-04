<<<<<<< HEAD
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
=======
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
>>>>>>> 2bd0bb96d627c3ba1b7a2db6c695708b0b844adb
