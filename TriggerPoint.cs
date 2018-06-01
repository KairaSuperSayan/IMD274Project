using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPoint : MonoBehaviour {
  public  int counter = 0;



	// Use this for initialization
	 void OnTriggerEnter(Collider other)
     {
        counter++;
     }

    public void OnTriggerExit(Collider other)
    {
        counter--;
    }

    // Update is called once per frame
    void Update ()
    {

    }
}
