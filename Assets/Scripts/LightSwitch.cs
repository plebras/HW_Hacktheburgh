using UnityEngine;
using System.Collections;

public class LightSwitch : MonoBehaviour {


	public bool green;
	// Use this for initialization
	void Start () {
		gameObject.renderer.material.color = Color.red;
		green = false;
	}
	
	public void changeColor()
	{
		if (green)
		{
			gameObject.renderer.material.color = Color.red;
		}else{
			gameObject.renderer.material.color = Color.green;
		}
		green = !green;
	}

	public bool isGreen()
	{
		return green;
	}
}
