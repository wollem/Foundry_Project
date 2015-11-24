using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	CharacterController cc;
	
	public float speed = 1.0f;
	
	void Start () {
		cc = GetComponent<CharacterController>();
	}
	
	void Update () {
		cc.SimpleMove(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * speed);
	}
}