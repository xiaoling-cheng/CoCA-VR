using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_osc : MonoBehaviour {
    public float delta;  // Amount to move left and right from the start point
    public float speed;
    public float timeRunning = 0.0f;

    // Use this for initialization
    void Start () {
        speed = 0.01f;
    }
	
	// Update is called once per frame
	void Update () {

        timeRunning += Time.deltaTime;

        transform.position = new Vector3(0f, -delta * Mathf.Sin(timeRunning * speed *0.1f), 0f);

        if (Input.GetKeyDown(KeyCode.P))
            speed += 0.01f;

        if (Input.GetKeyDown(KeyCode.O))
            speed += -0.01f;

        if (Input.GetKeyDown(KeyCode.L))
            timeRunning = 0.0f;

    }
}
