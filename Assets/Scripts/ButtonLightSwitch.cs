using UnityEngine;
using System.Collections;

public class ButtonLightSwitch : MonoBehaviour {

	public int buttonNumber =1;
	public LightSwitchController lightController;
	// Use this for initialization
	void Start () {
		lightController = FindObjectOfType<LightSwitchController>();
		gameObject.renderer.material.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnEnterCollision(Collision coll)
	{
		Debug.Log ("Button Collide");
		if(coll.collider.CompareTag("bullet"){
			Debug.Log ("Colliding with bullet");
			lightController.Switch(buttonNumber);
		}
	}
}
