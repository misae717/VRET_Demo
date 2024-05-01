using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class FlashingLight : MonoBehaviour
{

    public float totalSeconds; 
    public float maxIntensity;  
    public Light myLight1;
    public Light myLight2;

    void Update()
    {
        myLight1.intensity += Time.deltaTime * totalSeconds;
        myLight2.intensity += Time.deltaTime * totalSeconds;
        if (myLight1.intensity >= maxIntensity && myLight2.intensity >= maxIntensity)
            myLight1.intensity -= Time.deltaTime * totalSeconds; 
            myLight2.intensity -= Time.deltaTime * totalSeconds;
        }
    }