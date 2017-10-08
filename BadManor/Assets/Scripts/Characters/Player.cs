﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Characters
{
    class Player : Character
    {

		public float moveTime = 0.1f;

		private Rigidbody2D rb2d;
		private DialogueManager dMan;


		private bool isConvo;

		void Start()
		{
			rb2d = GetComponent<Rigidbody2D> ();
			dMan = FindObjectOfType<DialogueManager> ();


            //HARD CODING RN

			isConvo = false;
		}

		void Update()
		{
			float moveHorizontal = Input.GetAxisRaw ("Horizontal");
			float moveVertical = Input.GetAxisRaw ("Vertical");

			if (isConvo) 
			{
				if (Input.GetKeyUp (KeyCode.Space)) 
				{
					Debug.Log ("CONTINUING CONVO");
					isConvo = dMan.NextLine ();
					if (!isConvo) {
						dMan.EndConvo ();
					}
				}
				return;
			}

			if (moveVertical != 0 || moveHorizontal != 0) 
			{
				Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0f);
				transform.Translate (movement * moveTime);
			}
		}

		void OnTriggerStay2D(Collider2D other)
		{
			//Debug.Log ("TRIGGER IN PLAYER");
			if (other.gameObject.tag == "NPC") 
			{
				if (Input.GetKeyUp (KeyCode.Space) && !isConvo) 
				{
					Debug.Log ("STARTING CONVO IN PLAYER");
					dMan.StartConvo ();
					isConvo = true;
				}
			}
		}

		void SetIsConvo(bool boo)
		{
			isConvo = boo;
		}

		void OnTriggerEnter2D(Collider2D other){
						if (other.gameObject.CompareTag ("ItemPickUp")) {
								other.gameObject.SetActive (false);
							}
					}
    }
}
