using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RobotController : MonoBehaviour
{
	public List<GameObject> manipulators = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }


	 float timeLeft = 0.01f;
	 float angle = 0;

    // Update is called once per frame
    void Update()
    {
  		timeLeft -= Time.deltaTime;
        if(timeLeft < 0)
        {
        	timeLeft = 0.01f;

	        foreach (GameObject o in GameObject.FindGameObjectsWithTag("First"))
        		o.transform.localRotation = Quaternion.Euler(0, 45.0f * (float) Math.Sin(angle), 0);
	        foreach (GameObject o in GameObject.FindGameObjectsWithTag("Second"))
        		o.transform.localRotation = Quaternion.Euler(0, 0, 45.0f * (float) Math.Sin(angle));
	        foreach (GameObject o in GameObject.FindGameObjectsWithTag("Third"))
        		o.transform.localRotation = Quaternion.Euler(0, 0, 45.0f * (float) Math.Sin(angle));
	        foreach (GameObject o in GameObject.FindGameObjectsWithTag("Forth"))
        		o.transform.localRotation = Quaternion.Euler(0, 0, 45.0f * (float) Math.Sin(angle));
	        foreach (GameObject o in GameObject.FindGameObjectsWithTag("Fifth"))
        		o.transform.localRotation = Quaternion.Euler(0, 0, 45.0f * (float) Math.Sin(angle));
	        foreach (GameObject o in GameObject.FindGameObjectsWithTag("Sixth"))
        		o.transform.localRotation = Quaternion.Euler(0, 0, 45.0f * (float) Math.Sin(angle));

        	angle += 0.01f;
    	}
    }
}
