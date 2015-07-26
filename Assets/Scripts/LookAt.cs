using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(GameObject.Find("FPSController") != null) 
		transform.LookAt(GameObject.Find("FPSController").transform);
	
	}
}
