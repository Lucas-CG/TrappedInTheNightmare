using UnityEngine;
using UnityEngine.UI;

public class OpenMap : MonoBehaviour
{

    bool mapOpen = false;
    RawImage rawimage;

    void Awake ()
    {
        rawimage = GetComponent<RawImage>();
    }


    void Update ()
    {

		if(Input.GetButton ("Submit") && !mapOpen)
        {
            rawimage.enabled = true;
            mapOpen = true;
        }


        if (Input.GetButton("Submit") && mapOpen)
        {
            rawimage.enabled = false;
            mapOpen = false;
        }

    }

}
