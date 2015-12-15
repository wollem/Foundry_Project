using UnityEngine;
using System.Collections;

public class PickUpItem : MonoBehaviour {
	public string itemName; 
	public Sprite image;

	void OnTriggerEnter(Collider col) {
		if(col.tag == "Player") {
			transform.parent = null;
			GetComponent<Collider>().isTrigger = false;
			GetComponent<Rigidbody>().isKinematic = false;
			GetComponent<Rigidbody>().useGravity = true;
		}
	}
}
