using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.L))
		{
			transform.Translate(new Vector3(0,-1 * Time.deltaTime,0));
		}

		if(Input.GetKey(KeyCode.P))
		{
			transform.Translate(new Vector3(0,1 * Time.deltaTime,0));
	}
}
}