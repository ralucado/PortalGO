﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Mechanism {

    public GameObject colliderBehind;
    protected Collider compColliderBehind;
    // Use this for initialization
    override protected void Start () {
        //Get them_Animator, which you attach to the GameObject you intend to animate.
        m_Animator = gameObject.GetComponent<Animator>();
        compColliderBehind = colliderBehind.GetComponent<Collider>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
