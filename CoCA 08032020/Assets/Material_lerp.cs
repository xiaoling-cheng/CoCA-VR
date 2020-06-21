﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Material_lerp : MonoBehaviour
{
    public float speed = 1.0f;
    public Color startColor;
    public Color endColor;
    float startTime;

    // Start is called before the first frame update
    void Start()
    {
        
        startTime = Time.time;
        
    }

    // Update is called once per frame
    void Update()
    {
        float t = (Time.time - startTime) * speed;
        GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, t);
    }
}
