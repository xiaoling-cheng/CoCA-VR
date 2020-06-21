using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_control1 : MonoBehaviour {
    public Renderer rend;
    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            rend.enabled = true;
        }
        if (Input.GetKeyUp(KeyCode.X))
        {
            rend.enabled = false;
        }
    }
}
