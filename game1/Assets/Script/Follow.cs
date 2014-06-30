using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {
	public GameObject followObject;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = followObject.transform.position;
	}
}
