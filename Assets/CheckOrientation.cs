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

    void Update()
    {
        float x = cubeObject.transform.rotation.x;
        float z = cubeObject.transform.rotation.z;
        if(!isRotated & ((Math.Abs(x) >= 145 & Math.Abs(x) <= 180) | (Math.Abs(z) >= 145 & Math.Abs(z) <= 180)))
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