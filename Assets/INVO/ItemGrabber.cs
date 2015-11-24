using UnityEngine;
using System.Collections;

public class ItemGrabber : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		if (col.collider.GetComponent<PickUpItem> () != null)
			Inventory.AddItem (col.collider.GetComponent<PickUpItem> ());
	}
}
