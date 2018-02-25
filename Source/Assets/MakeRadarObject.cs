﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeRadarObject : MonoBehaviour {
    public Image image;
	// Use this for initialization
	void Start () {
        radar.RegisterRadarObject(this.gameObject, image);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnDestroy()
    {
        radar.RemoveRadarObject(this.gameObject);  
    }
}
