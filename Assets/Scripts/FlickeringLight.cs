using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour {

    private float minFlickering;
    private float maxFlickering;
    private Light lightComponent;
    private float maxRange;
	// Use this for initialization
	void Start () {
        lightComponent = GetComponent<Light>();
        maxFlickering = lightComponent.intensity;
        minFlickering = maxFlickering - 1.0f;
        maxRange = lightComponent.range;
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Light>().intensity = Random.Range(minFlickering, maxFlickering);
        gameObject.GetComponent<Light>().range = Random.Range(0f, maxRange);

    }
}
