using UnityEngine;
using System.Collections;

public class sirenScript : MonoBehaviour {
	public AudioClip siren;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		babyScript.annoyance += 3;
		GetComponent<AudioSource>().PlayOneShot(siren,1);
	}
}
