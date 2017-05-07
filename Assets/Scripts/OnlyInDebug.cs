using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlyInDebug : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (!Debug.isDebugBuild)
        {
            gameObject.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
