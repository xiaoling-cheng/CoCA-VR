using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement1 : MonoBehaviour {
    public Vector3 startPos;
    public Vector3 startRot;

    // Use this for initialization
    void Start () {
        startPos = transform.position;
        startRot = transform.eulerAngles;
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 0, -8 * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, 0, 8 * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, 0, -10 * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 0, 10 * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 10 * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -10 * Time.deltaTime, 0));

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(10 * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-10 * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -4 * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 4 * Time.deltaTime, 0));
        }

      
        if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(new Vector3(4 * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.F))
        {
            transform.Rotate(new Vector3(-4 * Time.deltaTime, 0, 0));

        }

        if (Input.GetKey(KeyCode.K))
        {
            transform.position = startPos;
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.eulerAngles = startRot;
        }
    }
}
