using UnityEngine;
using System.Collections;

public class ChangeRoom : MonoBehaviour {

	//Add more if needed
	public Material wall;
	public Texture[] wallTextures;
	int currentWall;
	//
	public Material floor;
	public Texture[] floorTextures;
	int currentFloor;
	//
	public Material ceiling;
	public Texture[] ceilingTextures;
	int currentCeiling;

	void Activate() {
		wall.mainTexture = wallTextures[IncrementWrap(ref currentWall, wallTextures.Length)];
		floor.mainTexture = floorTextures[IncrementWrap(ref currentFloor, floorTextures.Length)];
		ceiling.mainTexture = ceilingTextures[IncrementWrap(ref currentCeiling, ceilingTextures.Length)];
	}

	int IncrementWrap(ref int num, int max) {
		num++;
		if(num >= max) num = 0;
		return num;
	}
}
