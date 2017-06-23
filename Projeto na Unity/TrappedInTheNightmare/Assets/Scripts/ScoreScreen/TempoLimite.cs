using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempoLimite : MonoBehaviour {


    Text text;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();

        if (TimerManager.allocatedTimeSeconds < 10)
        {
            text.text = "Tempo Limite: " + TimerManager.allocatedTimeMinutes.ToString() + ":0" + TimerManager.allocatedTimeSeconds.ToString();
        }

        else
        {
            text.text = "Tempo Limite: " + TimerManager.allocatedTimeMinutes.ToString() + ":" + TimerManager.allocatedTimeSeconds.ToString();
        }

    }
	
}
