using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class LightOnOff : MonoBehaviour
{

    public AudioClip togglesound;
    public AudioSource MusicSource; 
	public SteamVR_Input_Sources handType; // 1
	public SteamVR_Action_Boolean grab; // 3

    // Start is called before the first frame update
    void Start()
    {
        MusicSource.clip=togglesound;
        this.GetComponent<Light>().enabled= true;
    }

    // Update is called once per frame
    void Update()
    {
    	if (GetGrab())
		{
    		//print("Grabbed "+handType);

        	
        		if (this.GetComponent<Light>().enabled== true)
        			this.GetComponent<Light>().enabled= false;
        		else this.GetComponent<Light>().enabled= true;

                MusicSource.Play();
    }
}
    public bool GetGrab() // 2
	{  
    	return grab.GetState(handType);
	}
}
