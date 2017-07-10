using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOutAnimation : MonoBehaviour {


	// Update is called once per frame
	void Update () {
        GetComponentInChildren<Camera>().orthographicSize += (35 * Time.deltaTime);
	}
}
