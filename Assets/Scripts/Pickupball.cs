using UnityEngine;
using System.Collections;

public class Pickupball : MonoBehaviour {

	Transform mytransform;
	public Transform handTransform;
	public bool isHolding;
	public Transform ball;
	public Rigidbody ballBody;

	// Use this for initialization
	void Start () {
		mytransform = transform;
		isHolding = false;

	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 handPos = handTransform.position;

		if(!isHolding && Input.GetKeyDown (KeyCode.Q)){
		isHolding = true;
		
		}

		if(isHolding) {
			ball.transform.position = handPos;
			ballBody.useGravity = false;
			ballBody.isKinematic = true;
			ballBody.mass = 0;

			if(Input.GetKeyDown(KeyCode.Return)) {
				isHolding = false;

			}
		}

		if(!isHolding){

			ballBody.mass = 1;
			ballBody.useGravity = true;
			ballBody.isKinematic = false;

		}

	}
}
