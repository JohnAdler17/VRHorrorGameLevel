using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSounds : MonoBehaviour
{
	public AudioSource grasswalk;
    // Start is called before the first frame update
    void Start()
    {
        grasswalk = GetComponent<AudioSource>();
        Debug.Log("Floor sound started");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollision(Collision col)
    {
         
        if(col.gameObject.name =="GrassModel")
        {
            Debug.Log("Opened");
            grasswalk.Play();
        }
        else Debug.Log("Hit jackshit" + col.gameObject.name);
    }
}
