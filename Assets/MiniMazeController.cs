using UnityEngine;
using System.Collections;

public class MiniMazeController : MonoBehaviour {

	public Transform []doors = new Transform[6];
	public DoorSwitch doorSwitchScript;
	void Start () {
		int j = 0;
		for(int i = 0; i<transform.childCount; i++)
		{
			Transform temp = (Transform) transform.GetChild (i);
			if (temp.CompareTag("Door"))
				doors[j++] =  (Transform) transform.GetChild (i);
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void SwitchDoor(int i)
	{
		doorSwitchScript = doors[i].gameObject.GetComponent<DoorSwitch>();
		doorSwitchScript.Rotate();
	}
	
	public void Switch(int i)
	{
		
		if(i == 1){
			SwitchDoor (0);
			SwitchDoor (2);
		}
		if(i == 2){
			SwitchDoor (1);
			SwitchDoor (2);
		}
		if(i == 3){
			SwitchDoor (2);
			SwitchDoor (3);
			SwitchDoor (5);
		}
		if(i == 4){
			SwitchDoor (4);
			SwitchDoor (0);
		}
		if(i == 5){
			SwitchDoor (3);
			SwitchDoor (5);
		}
	}
}
