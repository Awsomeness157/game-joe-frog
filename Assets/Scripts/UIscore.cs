using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIscore : MonoBehaviour {

	Text myText;
	// Use this for initialization
	
	void Awake(){
		if(Application.loadedLevel == 0){
			basketball.score = 0;
		}
	}

	void Start () {
		myText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
		myText.text = "Score: " + basketball.score;

	}
}
