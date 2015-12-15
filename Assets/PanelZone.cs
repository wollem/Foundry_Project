using UnityEngine;
using System.Collections;

public class PanelZone : MonoBehaviour {

	Animation anim;

	void Start () {
		anim = GetComponent<Animation>();
	}
	
	void Update () {
	
	}

	void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "Player") {
			anim["PanelOpen"].speed = 1.0f;
			anim.Play("PanelOpen");
			anim.PlayQueued("PanelIdle", QueueMode.CompleteOthers);
		}
	}

	void OnTriggerExit(Collider col) {
		if(col.gameObject.tag == "Player") {
			anim["PanelOpen"].speed = -1.0f;
			anim["PanelOpen"].time = anim["PanelOpen"].length;
			anim.Play("PanelOpen");
		}
	}
}
