using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Move2 : MonoBehaviour
{

     
	public SteamVR_Input_Sources handType; // 1
	public SteamVR_Action_Vector2 mvmnt; // 3
	private Vector2 loc;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
    	loc = GetGrab();
    	Debug.Log("here is vector2"+loc);
}
    public Vector2 GetGrab() // 2
	{  
    	return mvmnt.GetAxis(handType);
	}
}
