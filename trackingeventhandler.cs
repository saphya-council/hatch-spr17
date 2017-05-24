using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TrackingEventHandler : MonoBehaviour, 
ITrackableEventHandler  {

	//private IEnumerator coroutine;
	private TrackableBehaviour mTrackableBehaviour;
	//private ImageTargetBehaviour mTarget;

	public GameObject button;
	public GameObject icon;
	public GameObject itarget;
	//public string targettype;


	void Start(){
		itarget.SetActive (false);
		//Vuforia tracker
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}

	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
			//Debug.Log ("i see you");
			//Debug.Log (targettype);
			//Debug.Log(mTrackableBehaviour.TrackableName);
			Debug.Log (itarget);
			OnTrackingFound ();

		}
	}   

	private void OnTrackingFound()
	{
		//if (mTrackableBehaviour.TrackableName == gameObject.GetComponent<ImageTargetBehaviour>().ImageTarget.ToString()) {

		button.GetComponent<CameraButton> ().ImageFound (icon);
		//itarget.SetActive(true);	
		//}
	}
}
