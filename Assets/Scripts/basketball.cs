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
void OnCollisionEnter(Collision colider){
	score++;
	myAudio.PlayOneShot(boink);
	Debug.Log (score);
}

}


