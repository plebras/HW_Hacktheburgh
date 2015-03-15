using UnityEngine;
using System.Collections;

public class DoorSwitch : MonoBehaviour
{

	public int pos = 0;
	public int numberOfPositions = 1;
	public Vector3[] positions;
	// Use this for initialization
	void Start () {
		gameObject.renderer.material.color = Color.yellow;
		numberOfPositions = transform.childCount + 1;
		positions = new Vector3[numberOfPositions];
		positions[0] = transform.position;
		for(int i = 0; i < numberOfPositions-1; i++)
			positions[i +1] = (Vector3) transform.GetChild(i).position;
	}
	
	public void Rotate()
	{
		pos++;
		if(pos >= numberOfPositions){
			pos = 0;
			if(numberOfPositions == 3)
				transform.Rotate(new Vector3(0,90,0));
		}
		transform.position = positions[pos];
		transform.Rotate(new Vector3(0,90,0));
	}
}

