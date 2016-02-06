using UnityEngine;
using System.Collections;

public class babyScript : MonoBehaviour {
	public static int annoyance = 0;
	public Texture tex;
	public AudioClip cry;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(annoyance<=18)
		GameObject.Find ("Score").GetComponent<TextMesh> ().text = annoyance + "/18";
		else
			GameObject.Find ("Score").GetComponent<TextMesh> ().text = "You're a monster";
	if (annoyance >= 18) 
		{
			GameObject.Find ("Plane (8)").GetComponent<Renderer>().material.mainTexture = tex;
			GameObject.Find ("Plane (9)").GetComponent<Renderer>().material.mainTexture = tex;
			GetComponent<AudioSource> ().PlayOneShot (cry, 1);
		
		}
	}


}
