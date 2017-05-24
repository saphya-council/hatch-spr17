using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManagement : MonoBehaviour {

	public GameObject hearts;
	float t;
	public AudioSource uhoh;
	public Animator feelings;
	//public AudioClip uhoh;

	// Use this for initialization
	void Start () {
		t = Time.time;
	}
	
	// Update is called once per frame

	void Update(){
		float elapsedTime = Time.time - t;
		int sec = (int)(elapsedTime%60);
		//int hours = (int)((t / 3600) % 24);
		if (sec >= 30) {
			Debug.Log ("Time's up!");
			uhoh.Play ();
			hearts.GetComponent<HeartSystem> ().HeartDeletion ();
			feelings.SetTrigger ("sad");
			Debug.Log ("SAD");
			t = Time.time;
		}
	}
}
