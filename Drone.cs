using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour {
    public bool Walk;	// Reference to the animator bool to trigger the state.

	public Animator anim;		// Reference to the animator component.
	private GameObject player;

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();
	}

	void OnTriggerEnter (Collider other){
		anim.SetBool("Walk", true);
	}

	void OnTriggerExit (Collider other){
		anim.SetBool("Walk", false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
