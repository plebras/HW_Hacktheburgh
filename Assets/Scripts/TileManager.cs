using UnityEngine;
using System.Collections;

public class TileManager : MonoBehaviour {

	public Transform []tiles = new Transform[100];
	public FloorTile tileScript;
	void Start () {
		for(int i = 0; i<transform.childCount; i++)
		{
			tiles[i] =  (Transform) transform.GetChild(i);
		}
	}
	
	// Update is called once per frame
	void Update () {
		bool solved = true;
		for(int i = 0; i<transform.childCount; i++)
		{
			tileScript = tiles[i].gameObject.GetComponent<FloorTile>();
			if (!tileScript.IsCorrectColor())
				solved = false;
		}
		if (solved)
			Destroy(transform.parent.gameObject);
	}
}
