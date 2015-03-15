using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	private float lifetime = 2.0f;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, lifetime);
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	void Awake() {	

	}
}
