using UnityEngine;
using UnityEngine.Networking;
using System;
using System.Collections;
using TMPro;

public class CheckOrientation : MonoBehaviour
{
    public GameObject cubeObject;
    public Light lightObject;
    bool isRotated = false;

    void Start()
    {
        lightObject.enabled = true;
    }

    void Update()
    {
        float x = cubeObject.transform.rotation.x;
        float z = cubeObject.transform.rotation.z;
        if(!isRotated & ((((Math.Abs(x)%360) >= 150 & (Math.Abs(x)%360) <= 180) & (Math.Abs(z)%360) < 30) | (((Math.Abs(z)%360) >= 150 & (Math.Abs(z)%360) <= 180) & (Math.Abs(x)%360) < 30)))
        {
            isRotated = true;
            lightObject.enabled = !lightObject.enabled;
        }
        if(isRotated & (Math.Abs(x) < 145 & Math.Abs(z) < 145))
        {
            isRotated = false;
        }
    }
}