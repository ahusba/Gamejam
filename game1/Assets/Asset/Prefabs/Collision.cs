using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {
	public Collider leftHand;
	// Use this for initialization
	void Start () {
	
	}

 	void OnTriggerEnter(Collider other)
		{
			//if (other.gameObject.name == "TopLeft")
			//{
				Debug.Log("TopLeft");
			//}


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

