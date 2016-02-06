using UnityEngine;
using System.Collections;

public class LightScript : MonoBehaviour {
	public Light myLight;
	private int x;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		babyScript.annoyance ++;
		if (x % 2 == 0) {

			myLight.enabled = false;
			x++;
		} else {
			myLight.enabled = true;
			x++;
		}
	}

}
