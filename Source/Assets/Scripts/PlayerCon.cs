using UnityEngine;
using System.Collections;
using Leap;

public class PlayerCon : MonoBehaviour 
{

	public float speed;

	Controller controller;
	Frame frame;
	HandList hands;
	Hand firstHand;

	private bool grabbing;

	void Start ()
	{
		controller = new Controller ();
		GetHands ();
	}

	void Update ()
	{
		if (!(Physics.Raycast (transform.position, Camera.main.transform.forward, 1.0f))) {
			if (grabbing){
				transform.position += Camera.main.transform.forward * speed * Time.deltaTime;
			}
		}
	}

	void LateUpdate()
	{
		GetHands ();
	}

	void GetHands()
	{
		frame = controller.Frame (); // this gets the current frame from the controller
		hands = frame.Hands;
		firstHand = hands [0];

		if (firstHand.GrabStrength >= .2f) {
			grabbing = true;
		} 
		else 
		{
			grabbing = false;
		}	
	}
}
