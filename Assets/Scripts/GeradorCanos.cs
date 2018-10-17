using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorCanos : MonoBehaviour {

	public GameObject canoPrefab;
	public float delay = 2f;

	// Use this for initialization
	void Start () {
		InvokeRepeating("GerarCano", delay, delay);
	}

	void GerarCano () {
		Instantiate(canoPrefab);
	}
}
