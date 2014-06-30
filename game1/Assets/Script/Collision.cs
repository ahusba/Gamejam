using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {
	public Collider physCollider;
	// Use this for initialization
	void Start () {
	
	}

 	void OnTriggerEnter(Collider other){
		//if (other.gameObject.name == "TopLeft")
		//{
			Debug.Log(other.gameObject.name);
		//}


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

