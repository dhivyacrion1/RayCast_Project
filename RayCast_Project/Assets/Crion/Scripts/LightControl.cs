using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    public static LightControl instance;

    public GameObject[] labLights; 

    void Awake()
    {
        instance = this;
    }

    public void TurnOnLights()
    {
        foreach (GameObject lightObj in labLights)
        {
            lightObj.SetActive(true);
        }
    }

    public void TurnOffLights()
    {
        foreach (GameObject lightObj in labLights)
        {
            lightObj.SetActive(false);
        }
    }
}
