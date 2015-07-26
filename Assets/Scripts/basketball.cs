using UnityEngine;
using System.Collections;

public class basketball : MonoBehaviour {


	public AudioClip boink;
	public AudioSource myAudio;
	public static int score;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		}

		

void OnTriggerEnter(Collider collider){
	
	float bBallVolume = GetComponent<Rigidbody>().velocity.magnitude/ 40;
	//Debug.Log ("bBallVolume: " + bBallVolume);
	if(collider.gameObject.tag == "head"){

	myAudio.PlayOneShot(boink, bBallVolume);
	//Debug.Log (score);
	
		score++;
		Debug.Log ("score:" + score);
	} 
	//else if (collider.gameObject.tag =="curry"){
		//Debug.Log ("Haha, you missed my head!");
	//}
	
	}

	void OnCollisionEnter(Collision Collider) {
		float bBallVolume = GetComponent<Rigidbody>().velocity.magnitude/ 40;
		myAudio.PlayOneShot(boink, bBallVolume);
	}

}


