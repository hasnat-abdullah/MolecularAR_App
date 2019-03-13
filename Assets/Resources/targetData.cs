using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Vuforia
{

	public class targetData : MonoBehaviour {

		public Transform TextTargetName;
        public Transform TextDescription;
        public Transform PanelDescription;
        public Transform TestInstruction;
        public Transform ButtonAction;

        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            StateManager sm = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

            foreach (TrackableBehaviour tb in tbs)
            {
                string name = tb.TrackableName;
                //gameObject TrackedObject = tb.gameObject.name;
                ImageTarget it = tb.Trackable as ImageTarget;
                Vector2 size = it.GetSize();

                Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);
			
//Evertime the target found it will show “name of target” on the TextTargetName. Button, Description and Panel will visible (active)

                TextTargetName.GetComponent<Text>().text = name;
                TextDescription.gameObject.SetActive(true);
                TestInstruction.gameObject.SetActive(false);
                //PanelDescription.gameObject.SetActive(true);

                //Hide lone pair by default
                //GameObject.Find ("LonePair").transform.localScale = new Vector3(0, 0, 0);
                //GameObject.Find ("LonePair").GetComponent<Renderer>().enabled = false;
                

//If the target name was Water then add listener to ButtonAction with location of the Water sound (locate in Resources/sounds folder) and set text on TextDescription a description of the zombie

                if(name == "Water"){
                    
                    TextDescription.GetComponent<Text>().text = "Water has 2 hydrogen atom, 1 oxygen atom. Polar molecule. Structure is bent. It has 2 lone pair. Angle between two bond is 109.47 degree. Chemical name is Dihydrogen oxide.";
                }



//If the target name was “unitychan” then add listener to ButtonAction with location of the unitychan sound (locate in Resources/sounds folder) and set text on TextDescription a description of the unitychan / robot

                if (name == "unitychan")
                {
                  
                    TextDescription.GetComponent<Text>().text = "A robot is a mechanical or virtual artificial agent, usually an electromechanical machine that is guided by a computer program or electronic circuitry, and thus a type of an embedded system.";
                }
            }
        }
        //Show Hide Lone Pair
        int counter1;
		public void showhideLonePair(){
			counter1++;
			if(counter1%2==0){
				GameObject.Find ("LonePair").GetComponent<Renderer>().enabled = false;
                Debug.Log("Active");
			}
			else{
				GameObject.Find ("LonePair").GetComponent<Renderer>().enabled = true;
                Debug.Log("inactive");
			}
		}

        //Show Hide Name
        int counter2;
		public void showhideName(){
			counter2++;
			if(counter2%2==0){
				GameObject.Find ("Name").GetComponent<Renderer>().enabled = false;
                Debug.Log("Active");
			}
			else{
				GameObject.Find ("Name").GetComponent<Renderer>().enabled = true;
                Debug.Log("inactive");
			}
		}

        //Show Hide Angle
        int counter3;
		public void showhideAngle(){
			counter3++;
			if(counter3%2==0){
				GameObject.Find ("Angle").GetComponent<Renderer>().enabled = false;
                Debug.Log("Active");
			}
			else{
				GameObject.Find ("Angle").GetComponent<Renderer>().enabled = true;
                Debug.Log("inactive");
			}
		}
    }
}