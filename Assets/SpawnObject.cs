using UnityEngine;
using System.Collections;

public class SpawnObject : MonoBehaviour {

	public Vector3 offset;
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
			GameObject obj = (GameObject)Instantiate(objectToSpawn, objectHolder.transform.position + offset, objectHolder.transform.rotation);
			obj.transform.parent = objectHolder.transform;
		}
	}
}
