using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour {


    //quanto tempo resta para concluir a fase, em segundos em número de ponto flutuante
    //exemplo: 1.5343643
    float remainingTime;
 
    //flag que indica se o tempo acabou (para game over)
    public static bool timeIsUp;

    //tempo que o jogador possui para passar da fase
    //minutos + segundos
    public int levelTimeMinutes;
    public int levelTimeSeconds;



    //o elemento da GUI
    Text timerText;

	// Inicialização
	void Awake () {

        timerText = GetComponent<Text>();
        remainingTime = levelTimeMinutes * 60f + levelTimeSeconds;
        timeIsUp = false;

        timerText.text = levelTimeMinutes.ToString() + ":" + levelTimeSeconds.ToString();

    }
	
	// Atualizações. Função chamada 1 vez a cada frame
	void Update () {

        if (!timeIsUp)
        {

            remainingTime -= Time.deltaTime;

            if (remainingTime < 0)
            {
                remainingTime = 0;
            }
            
            //FloorToInt dá a parte inteira do número decimal
            int remainingTimeMinutes = Mathf.FloorToInt(remainingTime / 60);
            int remainingTimeSeconds = Mathf.FloorToInt(remainingTime - (remainingTimeMinutes * 60));

            if (remainingTimeSeconds >= 10)
            {
                timerText.text = remainingTimeMinutes.ToString() + ":" + remainingTimeSeconds.ToString();
            }

            else
            {
                timerText.text = remainingTimeMinutes.ToString() + ":0" + remainingTimeSeconds.ToString();
            }


            if (remainingTime <= 0) timeIsUp = true;

        }
    }
}
