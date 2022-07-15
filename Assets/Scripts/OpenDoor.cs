using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_open_noise : MonoBehaviour
{	
	public AudioSource doorcreak;
    // Start is called before the first frame update
    void Start()
    {
        doorcreak = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
    	 
    	if(col.gameObject.name =="Controller (right)")
    	{
    		Debug.Log("Opened");
    		doorcreak.Play();
    	}
    	else Debug.Log("nope");
    }
}
