using UnityEngine;
using System.Collections;

public class ToggleSpotlight : MonoBehaviour {

	public GameObject[] lights;

	void Activate() {
		foreach(GameObject light in lights) {
			light.SetActive(!light.activeSelf);
		}
	}
}
