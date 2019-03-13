using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Screenshhotscriipt : MonoBehaviour {

	public void OnGUI(){
  		if (GUI.Button(new Rect(20, 20, 150, 100), "CaptureScreenshot")) {
    		ScreenCapture.CaptureScreenshot("Screenshot.png");
  		}
	}
}
