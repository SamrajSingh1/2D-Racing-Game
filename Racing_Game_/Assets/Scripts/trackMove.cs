﻿using UnityEngine;
using System.Collections;

public class trackMove : MonoBehaviour {

	public float speed;
	Vector2 offset;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    offset=new Vector2(0,Time.time*speed);
		GetComponent<Renderer>().material.mainTextureOffset = offset;
	}
}
