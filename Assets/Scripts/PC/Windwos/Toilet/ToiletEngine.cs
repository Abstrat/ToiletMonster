using UnityEngine;
using System.Collections;

public class ToiletEngine : MonoBehaviour {

	public int maxClick;
	private int clicked;

	public GameObject Devil;
	public GameObject Good;
	
	// Update is called once per frame
	void Update () {

		//Wenn Maus_Links drücken, dann...
		if (Input.GetMouseButtonDown (0)) {
			clicked = clicked + 1;

			if (clicked == maxClick) {
				Devil.SetActive (true);
			}

			if(clicked > maxClick){
				Devil.SetActive (false);
				Good.SetActive (true);
			}
		}
	}
}
