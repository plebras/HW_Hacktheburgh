using UnityEngine;
using System.Collections;

using Pose = Thalmic.Myo.Pose;

public class MovementController : MonoBehaviour {
	
	
	public float speed = 5.0f;
	public float gravity = 10.0f;
	//public Camera camera = null;
	//public float maxVelocityChange = 10.0f;
	private bool moveForward = false;

	// Myo variables
	public GameObject myo = null;
	private Pose _lastPose = Pose.Unknown;
	
	// Use this for initialization
	void Awake () {
		
		rigidbody.useGravity = false;
		//rigidbody.freezeRotation = true;
		
	}
	
	void Update () {

		ThalmicMyo thalmicMyo = myo.GetComponent<ThalmicMyo> ();
		//bool updateReference = false;
		//if (thalmicMyo.pose != _lastPose) {
			//_lastPose = thalmicMyo.pose;
		
		if (thalmicMyo.pose == Pose.FingersSpread) {
			if (moveForward) {
				moveForward = false;
			} else {
				moveForward = true;
			}
		}
		if (thalmicMyo.pose != _lastPose) {
			_lastPose = thalmicMyo.pose;
			if (thalmicMyo.pose == Pose.WaveIn) {
				rigidbody.transform.Rotate(0,-90,0);
			} else if (thalmicMyo.pose == Pose.WaveOut) {
				rigidbody.transform.Rotate(0,90,0);
			}
			if (thalmicMyo.pose == Pose.Fist) {
				shoot();
			}
		}
		if(moveForward){
			//updateReference = true;
			//Vector3 camForward = Camera.main.transform.TransformDirection (Vector3.forward);
			//Vector3 nextPos = new Vector3(camForward.x, 0, camForward.z);
			rigidbody.transform.localPosition += (transform.forward * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.W)) {

			rigidbody.transform.localPosition += (transform.forward * speed * Time.deltaTime);
		}

		/*
		if(Input.GetKey(KeyCode.S)){
		   rigidbody.transform.localPosition -= (transform.forward * speed * Time.deltaTime);
		}
		

		if(Input.GetKey(KeyCode.A)){
		   rigidbody.transform.localPosition -= transform.right * speed * Time.deltaTime;
		}
		

		if(Input.GetKey(KeyCode.D)){
		   rigidbody.transform.localPosition+= transform.right * speed * Time.deltaTime;	
		}*/
				
		//rigidbody.AddForce(new Vector3 (0, -gravity * rigidbody.mass, 0));

	}

	void shoot(){
		Vector3 shootingDirection = Camera.main.transform.TransformDirection (Vector3.forward);
		print (shootingDirection);
	}
}
