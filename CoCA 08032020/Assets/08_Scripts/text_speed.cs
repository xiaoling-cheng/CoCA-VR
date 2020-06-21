using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text_speed : MonoBehaviour {
    TextMesh textMesh;
    public Renderer rend;
    public float speed;
    public float speed_text;

    // Use this for initialization
    void Start () {
        speed = 0.05f;
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
            speed += 0.01f;

        if (Input.GetKeyDown(KeyCode.O))
            speed += -0.01f;

        speed_text = Mathf.RoundToInt(speed * 100);

        textMesh = GetComponentInChildren<TextMesh>();
        string labletext = "[Speed = " + speed_text + "]";
        textMesh.text = labletext;

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
