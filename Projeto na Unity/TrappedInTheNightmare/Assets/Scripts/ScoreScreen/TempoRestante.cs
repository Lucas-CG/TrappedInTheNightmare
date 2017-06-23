using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempoRestante : MonoBehaviour {

    Text text;

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();


        if (TimerManager.remainingTimeSeconds < 10)
        {
            text.text = "Tempo Restante: " + TimerManager.remainingTimeMinutes.ToString() + ":0" + TimerManager.remainingTimeSeconds.ToString();
        }

        else
        {
            text.text = "Tempo Restante: " + TimerManager.remainingTimeMinutes.ToString() + ":" + TimerManager.remainingTimeSeconds.ToString();
        }

    }

}
