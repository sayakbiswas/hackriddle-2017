﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneTriggerScript : MonoBehaviour {
    public bool isPhonePicked = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("triggered");
        if (other.transform.name == "palm")
        {
            isPhonePicked = true;
        }
    }
}
