using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class FlashingLight : MonoBehaviour
{

    public float totalSeconds; 
    public float maxIntensity;  
    public Light myLight;     

    void Update()
    {
        myLight.intensity += Time.deltaTime * totalSeconds;
        if (myLight.intensity >= maxIntensity)
            myLight.intensity -= Time.deltaTime * totalSeconds; 
        }
    }