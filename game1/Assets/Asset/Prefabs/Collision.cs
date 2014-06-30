using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {
	public Collider physicsCollider;
	// Use this for initialization
	void Start () {
	
	}

 	void OnTriggerEnter(Collider other){	
		Debug.Log(other.gameObject.name);		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

