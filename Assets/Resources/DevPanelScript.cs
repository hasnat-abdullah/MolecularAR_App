using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DevPanelScript : MonoBehaviour {

	public GameObject DevPanel;
	int counter;
	public void showhidePanel(){
		counter++;
		if(counter%2==0){
		DevPanel.gameObject.SetActive(false);
		}
		else
		{
			DevPanel.gameObject.SetActive(true);
		}
	}


}
