using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_control : MonoBehaviour {
    TextMesh textMesh;
    public Renderer rend;
    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rend.enabled = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rend.enabled = false;
        }
    }
}
