using UnityEngine;
using System.Collections;

public class GameOverSoundandRestart : MonoBehaviour {



	public AudioClip EndSound;
	public AudioSource myAudioSource;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		myAudioSource.PlayOneShot (EndSound);

		if(Input.GetKeyDown(KeyCode.R)){
			Application.LoadLevel (0);
		}


	}

	void PlaySound(){
		myAudioSource.PlayOneShot(EndSound);
	}
}
