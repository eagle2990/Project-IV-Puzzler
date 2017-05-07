using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningEffect : MonoBehaviour
{
    public float threshold;
    private Light light;

    // Use this for initialization
    void Start()
    {
        light = gameObject.GetComponent<Light>();
        light.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.value >= threshold)
        {
            light.enabled = true;
        }
        else
        {
            light.enabled = false;
        }
    }
}
