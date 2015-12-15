using UnityEngine;
using System.Collections;

public class TouchPanel : MonoBehaviour {

	public MonoBehaviour action;

	void Start () {
	
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Z)) {
			action.SendMessage("Activate");
		}
	}

	void OnTriggerEnter(Collider col) {
		if(col.tag == "Player") {
			action.SendMessage("Activate");
		}
	}
}
