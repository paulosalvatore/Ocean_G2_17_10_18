using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Jogador : MonoBehaviour {

	Rigidbody2D rb;

	public float forcaPulo = 200f;

	int pontos = 0;
	public Text pontosText;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Pular();
		}
	}

	private void Pular()
	{
		rb.velocity = Vector2.zero;
		rb.AddForce(Vector2.up * forcaPulo);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Canos"))
		{
			SceneManager.LoadScene(0);
		}
	}

	private void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.CompareTag("ColisorPontos"))
		{
			pontos++;
			pontosText.text = "Pontos: " + pontos;
		}
	}
}
