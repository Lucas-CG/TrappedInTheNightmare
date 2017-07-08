using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeCatch : MonoBehaviour {

    private int numbersCount;

	// Use this for initialization
	void Awake () {
        numbersCount = 0;
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CodeNumber"))
        {
            other.gameObject.SetActive(false);
            numbersCount++;

        }

        if (other.gameObject.CompareTag("CodeDoor"))
        {
            if (numbersCount == 4)
            {
                other.gameObject.SetActive(false);
            }
        }
    }
}
