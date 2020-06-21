using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left_band : MonoBehaviour {
    public float speed_;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            transform.Translate(new Vector3(0, 0, -1 * Time.deltaTime * speed_));
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            transform.Translate(new Vector3(0, 0, 1 * Time.deltaTime * speed_));
        }

        //scale middle bar
        if (Input.GetKey(KeyCode.Alpha3))
        {
            transform.localScale += new Vector3(0, 0, -0.1F);
        }

        if (Input.GetKey(KeyCode.Alpha4))
        {
            transform.localScale += new Vector3(0, 0, 0.1F);
        }
    }
}
