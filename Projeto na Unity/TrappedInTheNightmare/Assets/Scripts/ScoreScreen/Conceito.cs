using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conceito : MonoBehaviour {

    Text text;

    public static int pontos;

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();

        if (Pontos.pontos >= 7000) text.text = "EXCELENTE!";
        else if (Pontos.pontos >= 5000) text.text = "BOM!";
        else if (Pontos.pontos >= 3000) text.text = "RAZOÁVEL";
        else text.text = "LESMA";

    }

}

