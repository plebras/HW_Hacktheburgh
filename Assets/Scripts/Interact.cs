using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		Vector3 fwd = transform.TransformDirection (Vector3.forward);
		RaycastHit hitObject;
		if (Physics.Raycast (transform.position, fwd, out hitObject, 100f)) {
			print ("Looking at: "+hitObject.collider.tag);
			Debug.DrawRay(transform.position, fwd,Color.blue, 100f);
			if(Input.GetKey("e")) {
				if(hitObject.collider.CompareTag("Button")) {
					//TODO: put item in inventory
					hitObject.collider.gameObject.GetComponent<ButtonLightSwitch>().ButtonAction();

				}
				//else if(hitObject.collider.CompareTag("Scenery")) {
					//Scenery sc = hitObject.collider.GetComponent<Scenery>();
					//if(!sc.isAttached())
					//	sc.attachTo(transform.Find("Main Camera"));
				//}
			}
		}
	}
}
