using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraButton : MonoBehaviour
{
	//private IEnumerator coroutine;

	//public Button resource;
	public GameObject arcamera;
	public GameObject normalcamera;
	public GameObject hearts;
	public GameObject menu;
	public GameObject dragon;
	public Animator feelings;
	//public GameObject icon;
	public GameObject target;
	public AudioSource yay;

	// Use this for initialization
	void Start () {
		arcamera.SetActive (false);
		Button btn = GetComponent<Button> ();
		btn.onClick.AddListener (ARCameraOn);
		//icon.SetActive (false);
		//Animator dragonfeels = feelings.GetComponent<Animator> ();
	}
		
	// Update is called once per frame
	void ARCameraOn () {
		if (hearts.GetComponent<HeartSystem> ().hearts.Length != 3) {	
			arcamera.SetActive (true);
			menu.SetActive (false);
			normalcamera.SetActive (false);
			dragon.SetActive (false);

			//add heart
			target.SetActive(true);
			target.GetComponent<TrackingEventHandler>();

			//play 3d food animation
		} else if(hearts.GetComponent<HeartSystem> ().hearts.Length == 3){
			feelings.SetTrigger("happy");
		}
	}

	public void ImageFound(GameObject token) 
	{
		// Return to gui when target is lost
		arcamera.SetActive (false);
		menu.SetActive (true);
		normalcamera.SetActive (true);
		dragon.SetActive (true);

		//show icon!
		//coroutine = WaitAndPopUp(2.0f);
		StartCoroutine (WaitAndPopUp(token));

		// Add heart when target is found
		hearts.GetComponent<HeartSystem> ().HeartAddition ();

		//heart animation
		feelings.SetTrigger("happy");
		Debug.Log ("HAPPY");
	}

	IEnumerator WaitAndPopUp(GameObject x)
	{
		yay.Play ();
		x.SetActive (true);
		yield return new WaitForSeconds (2.0f);
		x.SetActive (false);

	}
}
