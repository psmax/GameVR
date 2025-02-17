﻿using UnityEngine;
using System.Collections;

public class HeadLookWalk : MonoBehaviour {
    public float velocity = 0.7f;
    public bool isWalking = false;

    private Clicker clicker = new Clicker();
    private CharacterController controller;
	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (clicker.clicked())
        {
            isWalking = !isWalking;
        }
        if (isWalking)
        {
            controller.SimpleMove(Camera.main.transform.forward * velocity);
        }
    }
}
