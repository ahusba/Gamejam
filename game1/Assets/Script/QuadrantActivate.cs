using UnityEngine;
using System.Collections;

public class QuadrantActivate : MonoBehaviour {
	bool show;
	// Use this for initialization
	void Start () {
		renderer.enabled = false;
		show = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (show) {
			renderer.enabled = true;
		} else {
			renderer.enabled = false;
		}
	}
	public void Activate(){
		show = true;
	}

	public void Deactivate(){
		show = false;
	}
}
