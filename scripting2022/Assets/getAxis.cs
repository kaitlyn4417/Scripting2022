using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getAxis : MonoBehaviour
{
    //axis
    public float range;
    public Text textOutput;
    void Update () 
    {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;
        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "Value Returned: " + h.ToString("F2");  
    }
    
    //axis raw
    public float range;
    public Text textOutput;
    void Update () 
    {
        float h = Input.GetAxisRaw("Horizontal");
        float xPos = h * range;
        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "Value Returned: " + h.ToString("F2");  
    }
    
    //dual axis
    public Text horizontalValueDisplayText;
    public Text verticalValueDisplayText;
    public float hRange;
    public float vRange;
    void Update ()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float yPos = v * vRange;
        transform.position = new Vector3(xPos, 0, vPos);
        horizontalValueDisplayText.text = h.ToString("F2");
        verticalValueDisplayText.text = v.ToString("F2");
    }
}
