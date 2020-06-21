using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_controller : MonoBehaviour {

	// Use this for initialization
	void Start () {

        //Screen.SetResolution(3840, 1200, false);

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit(); }
	}
}
