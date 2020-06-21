using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WTF : MonoBehaviour
{
    public Matrix4x4 AlternateMatrix;
    private Camera targetCamera;

    void Start()
    {
        targetCamera = GetComponent<Camera>();
        AlternateMatrix = targetCamera.projectionMatrix;
    }

    void Update()
    {
        targetCamera.projectionMatrix = AlternateMatrix;
    }
}
