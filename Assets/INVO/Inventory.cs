using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class Inventory : MonoBehaviour {
	static Inventory instance;
	List<PickUpItem> items;

	bool showGUI = false;

	public Texture2D inventoryBackground;
	public int rows = 5, columns = 5;

	void Start () {
		instance = this;
		items = new List<PickUpItem>();
	}
	
	void Update () {
		if(Input.GetButtonDown("Fire1")) {
			RaycastHit hit;
			if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit)) {
				PickUpItem item = hit.collider.GetComponent<PickUpItem>();
				if(item != null){
					items.Add(item);
					Destroy(item.gameObject);
				}
			}
		}

		if(Input.GetKeyDown(KeyCode.Tab)) {
			if(showGUI)
				HideInventory();
			else
				ShowInventory();
		}
	}

	public static void AddItem(PickUpItem item){
		instance.items.Add (item);
		Destroy (item.gameObject);
	}

	void ShowInventory() {
		Time.timeScale = 0f;
		showGUI = true;
	}

	void HideInventory() {
		Time.timeScale = 1f;
		showGUI = false;
	}

	void OnGUI() {
		if(showGUI) {
			GUI.color = Color.white;
			float wPadding = Screen.width/10f;
			float hPadding = Screen.height/10f;

			float windowWidth = Screen.width - wPadding*2f;
			float windowHeight = Screen.height - hPadding*2f;

			float titlePadding = windowHeight/10f;

			float windowHeightWTitle = windowHeight - titlePadding;

			float wInPadding = windowWidth/24f;
			float hInPadding = windowHeightWTitle/20f;

			float boxWidth = (windowWidth - (wInPadding*columns))/columns;
			float boxHeight = (windowHeightWTitle - (hInPadding*rows))/rows;

			GUI.skin.label.alignment = TextAnchor.UpperCenter;
			GUI.Label(new Rect(wPadding, hPadding, windowWidth, windowHeight), "Inventory", GUI.skin.label);
			GUI.Box(new Rect(wPadding, hPadding, windowWidth, windowHeight), inventoryBackground);
			for(int i = 0; i < columns; i++) {
				for(int j = 0; j < rows; j++) {
					int index = columns * j + i;
					if(items.Count > index) {
						PickUpItem item = items[index];
						GUI.Box(new Rect(wPadding + wInPadding/2f + (boxWidth+wInPadding)*i, hPadding + titlePadding + hInPadding/2f + (boxHeight+hInPadding)*j, boxWidth, boxHeight), item.image);
						GUI.Label(new Rect(wPadding + wInPadding/2f + (boxWidth+wInPadding)*i, hPadding + titlePadding + hInPadding/2f + (boxHeight+hInPadding)*j, boxWidth, boxHeight), item.name);
					} else {
						GUI.Box(new Rect(wPadding + wInPadding/2f + (boxWidth+wInPadding)*i, hPadding + titlePadding + hInPadding/2f + (boxHeight+hInPadding)*j, boxWidth, boxHeight), "");
					}
				}
			}
		}
	}
}
