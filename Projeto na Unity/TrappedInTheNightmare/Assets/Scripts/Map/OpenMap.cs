using UnityEngine;
using UnityEngine.UI;

public class OpenMap : MonoBehaviour
{

    public RawImage rawimage;
    float timer = 0f;
 
    void Update ()
    {
        timer += Time.deltaTime;

        if (Input.GetButton("Map") && timer > 0.2f)
        {
            rawimage.enabled = !rawimage.enabled;
            timer = 0f;
        }

    }

}
