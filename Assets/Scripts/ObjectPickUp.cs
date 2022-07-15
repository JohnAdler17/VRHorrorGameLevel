using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickUp : MonoBehaviour
{
	public GameObject bear;
	public AudioSource firstobjup;
    // Start is called before the first frame update
    void Start()
    {
        firstobjup = GetComponent<AudioSource>();
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
    		firstobjup.Play();
    		Destroy(bear);
    		;
    	}
    	//else Debug.Log("nope");
    }
}
