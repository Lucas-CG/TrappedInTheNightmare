using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeCatch : MonoBehaviour {

    private int numbersCount;
    private Quaternion originalRotationValue;

	// Use this for initialization
	void Awake () {
        numbersCount = 0;
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CodeNumber"))
        {
            //other.gameObject.SetActive(false);

            other.gameObject.GetComponent<MeshCollider>().enabled = false;
            other.gameObject.GetComponent<Rotator>().enabled = false;

            foreach (Renderer renderer in other.gameObject.GetComponentsInChildren<Renderer>())
            {
                print(renderer);
                renderer.enabled = !renderer.enabled;

            }

            other.gameObject.transform.rotation = Quaternion.identity;

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
