using UnityEngine;
using System.Collections;

public class babyScript : MonoBehaviour {
	GameObject baby;
	AudioSource sound;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void babyisAwake() {
		baby = GameObject.Find ("baby");
		Debug.Log ("You win");

	}

}
