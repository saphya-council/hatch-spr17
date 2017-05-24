using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour {

	public GameObject[] hearts;
	public GameObject heartmid;
	public GameObject heartleft;
	public GameObject heartright;
	public GameObject alive;
	public GameObject dead;
	//public Animator feelings;

	// Use this for initialization
	void Start () {
		alive.SetActive (true);
		dead.SetActive (false);
	}

	void Update()
	{
		if (hearts.Length == 0){
			//Debug.Log ("You dead, son!");
			dead.SetActive (true);
			alive.SetActive (false);
		} else if (hearts.Length >= 1){
			alive.SetActive (true);
			dead.SetActive (false);
		}
	}

	public void HeartAddition()
	{
		if (hearts.Length == 3) {
			Debug.Log ("You love me too much!");
			//feelings.SetTrigger("happy");
		} else if (hearts.Length == 2) {
			int index = hearts.Length;
			System.Collections.Generic.List<GameObject> list = new System.Collections.Generic.List<GameObject> (hearts);
			//Debug.Log ("adding...");
			list.Add (heartright);
			heartright.SetActive (true);
			hearts = list.ToArray ();
		} else if (hearts.Length == 1) {
			int index = hearts.Length;
			System.Collections.Generic.List<GameObject> list = new System.Collections.Generic.List<GameObject> (hearts);
			//Debug.Log ("adding...");
			list.Add (heartmid);
			heartmid.SetActive (true);
			hearts = list.ToArray ();
		} else if (hearts.Length == 0) {
			int index = hearts.Length;
			System.Collections.Generic.List<GameObject> list = new System.Collections.Generic.List<GameObject> (hearts);
			//Debug.Log ("adding...");
			list.Add (heartleft);
			heartleft.SetActive (true);
			hearts = list.ToArray ();
		}
	}
	// Update is called once per frame

	public void HeartDeletion () {	
		if (hearts.Length > 0) {	
			int index = hearts.Length;
			System.Collections.Generic.List<GameObject> list = new System.Collections.Generic.List<GameObject> (hearts);
			//Debug.Log ("deleting...");
			hearts [index - 1].SetActive (false);
			list.Remove (hearts [index - 1]);
			hearts = list.ToArray ();
		}
	}
}
