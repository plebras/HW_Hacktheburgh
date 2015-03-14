using UnityEngine;
using System.Collections;

public class LightSwitchController : MonoBehaviour {

	public Transform []lightSwitches = new Transform[4];
	public LightSwitch lightScript;
	void Start () {
		for(int i = 0; i<transform.childCount; i++)
		{
			lightSwitches[i] =  (Transform) transform.GetChild(i);
		}
	}
	
	// Update is called once per frame
	void Update () {
		bool solved = true;
		for(int i = 0; i<4; i++)
		{
			lightScript = lightSwitches[i].gameObject.GetComponent<LightSwitch>();
			if (!lightScript.isGreen())
				solved = false;
		}
		if (solved)
			Destroy(transform.parent.gameObject);
	}

	void SwitchLight(int i)
	{
		lightScript = lightSwitches[i].gameObject.GetComponent<LightSwitch>();
		lightScript.changeColor();
	}

	public void Switch(int i)
	{

		if(i == 1){
			SwitchLight (0);
			SwitchLight (1);
			SwitchLight (2);
		}
		if(i == 2){
			SwitchLight (1);
			SwitchLight (2);
			SwitchLight (3);
		}
		if(i == 3){
			SwitchLight (1);
			SwitchLight (2);
		}
	}
}
