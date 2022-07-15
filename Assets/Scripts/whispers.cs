using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whispers : MonoBehaviour
{	public AudioSource whisper;
	private bool played = false;
    // Start is called before the first frame update
    void Start()
    {
        whisper = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
    	 
    	if(col.gameObject.name =="Controller (right)")
    	{
    		//Debug.Log("Opened");
    			if(played == false){
    			whisper.Play();
    			played=true;}

    	}
    	//else Debug.Log("nope");
    }
}