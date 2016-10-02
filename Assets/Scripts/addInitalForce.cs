﻿using UnityEngine;
using System.Collections;

public class addInitalForce : MonoBehaviour {

	// Use this for initialization
	public float thrust;
	public GameObject gameManager;
	private Rigidbody rb;
	private Vector3 vel;
	private Vector3 spin;
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.AddForce (2, 4, 10, ForceMode.Impulse);
		rb.angularVelocity = new Vector3 (0f, 0.6f);
	}
	
	// Update is called once per frame
	void Update () {
		vel = rb.velocity;
		spin = rb.angularVelocity;
		rb.AddForce (Vector3.Cross(vel, spin));
	}

	public void reInitialize () {
		rb.velocity = Vector3.zero;
		rb.angularVelocity = Vector3.zero;
		transform.position = new Vector3 (0f, 5f, 0f);
		rb.AddForce (2, 4, 10, ForceMode.Impulse);
	}
}
	