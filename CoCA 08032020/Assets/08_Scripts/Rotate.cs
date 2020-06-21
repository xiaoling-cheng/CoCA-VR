using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float x_Rotation_Speed = 0f;
    public float y_Rotation_Speed = 0f;
    public float z_Rotation_Speed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(x_Rotation_Speed, y_Rotation_Speed, z_Rotation_Speed);
    }
}
