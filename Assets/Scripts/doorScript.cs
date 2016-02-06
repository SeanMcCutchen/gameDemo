using UnityEngine;
using System.Collections;

public class doorScript : MonoBehaviour {
	public AudioClip doorslam;
	public Light doorlight;
	private int x= 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		babyScript.annoyance += 3;
		if (x % 2 == 0) {
			GetComponent<AudioSource> ().PlayOneShot (doorslam, 1);
			doorlight.enabled = false;
			x++;
		} else {
			doorlight.enabled = true;
			x++;
		}
	}
}
