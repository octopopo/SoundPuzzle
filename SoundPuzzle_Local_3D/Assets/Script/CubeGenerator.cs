﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour {

    public float height;
    public float width;
    public GameObject m_Cube;

	// Use this for initialization
	void Start () {
        height = Camera.main.orthographicSize * 2;
        width = height * Camera.main.aspect;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
