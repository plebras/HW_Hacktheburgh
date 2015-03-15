using UnityEngine;
using System.Collections;

public class MazeButton : MonoBehaviour {

	public int buttonNumber =1;
	public MiniMazeController mazeController;
	// Use this for initialization
	void Start () {
		mazeController = FindObjectOfType<MiniMazeController>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.CompareTag("Bullet")){
			ButtonAction ();
		}
	}

	void ButtonAction()
	{
		mazeController.Switch(buttonNumber);
	}
}
