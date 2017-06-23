using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontos : MonoBehaviour {


    Text text;

    public static float pontos;

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();

        float remainingTimeInSeconds = TimerManager.remainingTimeMinutes * 60 + TimerManager.remainingTimeSeconds;

        float allocatedTimeInSeconds = TimerManager.allocatedTimeMinutes * 60 + TimerManager.allocatedTimeSeconds;

        pontos = Mathf.FloorToInt( 10000 * (remainingTimeInSeconds / allocatedTimeInSeconds) );

        text.text = "Pontos: " + pontos.ToString();

    }

}
