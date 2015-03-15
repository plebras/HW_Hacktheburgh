using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public int life = 2;
	public float maxSpeed = 1f;

	// Use this for initialization
	void Start () {
		float yAngle = Random.Range(0, 3) * 90;
		transform.Rotate (new Vector3 (0, yAngle, 0));
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 fwd = transform.TransformDirection (Vector3.forward);
		Debug.DrawRay(transform.position, fwd);
		if (Physics.Raycast (transform.position, fwd, 2.4f)) {
			float yAngleInc = Random.Range(1, 3)*90;
			transform.Rotate (new Vector3 (0, yAngleInc, 0));
			//float yAngle = transform.rotation.eulerAngles.y + yAngleInc;
			//if(yAngle >= 360) yAngle -= 360;
		}
		int rotY = (int)transform.rotation.eulerAngles.y;
		float x = transform.position.x;
		float z = transform.position.z;
		switch(rotY){
			case 0 :
				x = transform.position.x-0.05f;
				break;
			case 90 :
				z = transform.position.z+0.05f;
				break;
			case 180:
				x = transform.position.x+0.05f;
				break;
			case 270:
				z = transform.position.z-0.05f;
				break;
		}
		float step = maxSpeed + Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, new Vector3 (x, transform.position.y, z), step);
	
	}

	void OnCollisionEnter(Collision coll) {
		if(coll.collider.CompareTag("bullet")){
			life -=1;
		}
		if(life == 0) {
			GameObject.Destroy(gameObject);
		}
	}
}
