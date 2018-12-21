using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //uI사용

public class PlayerManager : MonoBehaviour {

    public Text myText;
	
	void Update () {
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            myText.text = "Trigger : True\n";
        }
        else
        {
            myText.text = "Trigger : False\n";
        }


        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            myText.text += "Trigger (Down) : True\n";
        }
        else
        {
            myText.text += "Trigger  (Down) : False\n";
        }


        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger))
        {
            myText.text += "Trigger (Up) : True\n";
        }
        else
        {
            myText.text += "Trigger (Up) : False\n";
        }


        if (OVRInput.Get(OVRInput.Button.One))
        {
            myText.text += "\nTouch One : True\n";
        }
        else
        {
            myText.text += "\nTouch One : False\n";
        }

        //touch
        Vector2 coord = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
        myText.text += string.Format("Touch [x:{0}][y:{1}]", coord.x, coord.y);

    }
}
