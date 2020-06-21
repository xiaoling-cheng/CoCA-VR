using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middle_band : MonoBehaviour
{
    public float speed_;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //move middle bar
        if (Input.GetKey(KeyCode.Alpha5))
        {
            transform.Translate(new Vector3(0, 0, -1 * Time.deltaTime * speed_));
        }
        if (Input.GetKey(KeyCode.Alpha6))
        {
            transform.Translate(new Vector3(0, 0, 1 * Time.deltaTime * speed_));
        }

        //scale middle bar
        if (Input.GetKey(KeyCode.Alpha7))
        {
            transform.localScale += new Vector3(0, 0, -0.1F);
        }

        if (Input.GetKey(KeyCode.Alpha8))
        {
            transform.localScale += new Vector3(0, 0, 0.1F);
        }
        //transform.localScale += new Vector3(0.1F, 0, 0);
    }
}