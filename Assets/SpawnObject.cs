using UnityEngine;
using System.Collections;

public class SpawnObject : MonoBehaviour {

	public GameObject objectHolder;
	public GameObject objectToSpawn;

//	void Start () {
//	
//	}
//	
//	void Update () {
//	
//	}

	void Activate() {
		if(objectHolder.transform.childCount == 0) {
			GameObject obj = (GameObject)Instantiate(objectToSpawn, objectHolder.transform.position + Vector3.up, objectHolder.transform.rotation);
			obj.transform.parent = objectHolder.transform;
		}
	}
}
