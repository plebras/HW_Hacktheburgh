using UnityEngine;
using System.Collections;

public class FloorTile : MonoBehaviour {

	int color = 0;
	public int correctColor = 0;
	// Use this for initialization
	void Start () {
		SetColor ();

	}

	void SetColor()
	{
		if(color > 2)
			color = 0;
		if(color == 0)
			gameObject.renderer.material.color = new Color(0.86f,0.3f,0f,1f);
		if(color == 1)
			gameObject.renderer.material.color = new Color(0.1f,0.15f,0.48f,1f);
		if(color == 2)
			gameObject.renderer.material.color = new Color(0.91f,0.8f,0.18f,1f) ;

	}
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision){
		Debug.Log("COLLIDING");
		if (collision.collider.CompareTag("Player")){
			Debug.Log("COLLIDING WithPlayer");
			ChangeColor();
		}
	}

	void ChangeColor(){
		color++;
		SetColor ();
	}
	
	public bool IsCorrectColor(){
		return (color == correctColor);
	}
}
