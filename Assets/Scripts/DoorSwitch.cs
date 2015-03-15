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
		positions = new Vector3[numberOfPositions];
		positions[0] = transform.position;
		for(int i = 1; i < numberOfPositions; i++)
			positions[i] = (Vector3) transform.GetChild(i).position;
	}
	
	public void Rotate()
	{
		pos++;
		if(pos >= numberOfPositions)
			pos = 0;
		transform.position = positions[pos];
		transform.Rotate(new Vector3(0,90,0));
	}
}

