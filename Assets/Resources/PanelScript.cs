using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelScript : MonoBehaviour {

	public GameObject Panel;
	int counter;
	public void showhidePanel(){
		counter++;
		if(counter%2==0){
		Panel.gameObject.SetActive(false);
		}
		else
		{
			Panel.gameObject.SetActive(true);
		}
	}


}
