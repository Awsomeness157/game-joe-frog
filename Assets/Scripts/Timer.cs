using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {


	Text myText; 
	float timePlayed = 15;

	// Use this for initialization
	void Awake () {
		timePlayed = 15;


	}

	void Start(){
		myText = GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(timePlayed);
	 	
	 	myText.text = "Timer: " + timePlayed;

		if (timePlayed > 0){
			timePlayed  -= Time.deltaTime;
		} else{
			Application.LoadLevel("Gameover");

		}




	}
}
