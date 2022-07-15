using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
 public class Movement : MonoBehaviour
 {
     private Vector2 trackpad;
     private float Direction;
     private Vector3 moveDirection;
    public AudioSource grasswalk;
     public Transform rig;
     public SteamVR_Input_Sources Hand;//Set Hand To Get Input From
     public float speed;
     public GameObject Head;
     public CapsuleCollider Collider;
     public GameObject AxisHand;//Hand Controller GameObject
     public float Deadzone;//the Deadzone of the trackpad. used to prevent unwanted walking.
     // Start is called before the first frame update
     public int i=0;
     public Rigidbody door1;
     public Rigidbody door2;
     public Rigidbody door3;
     public Rigidbody door4;
     public AudioSource Intro1;
     public AudioSource firstobjup;
     void Start()
    {
        grasswalk = GetComponent<AudioSource>();
        Intro1.Play();


    }
     void Update()
     {

     	
         trackpad = SteamVR_Actions._default.MovementAxis.GetAxis(Hand);
         Debug.Log(trackpad);
         rig.position += (transform.right*trackpad.x+transform.forward*trackpad.y)*Time.deltaTime*4;
         rig.position = new Vector3(rig.position.x,0,rig.position.z);
         if(trackpad.x!=0 || trackpad.y!=0 )
            if(count()==1)
                if(grasswalk.isPlaying == false)
                grasswalk.Play();
       
     }

     int count()
     {  i++;
        if(i%30==0)
        return 1;
        else return 0;
     }

     void OnCollisionEnter(Collision col)
    {
         
        if(col.gameObject.name =="Teddybear")
        {
            Debug.Log("Opened");
            if(door1.isKinematic==true)
                door1.isKinematic=false;
            firstobjup.Play();

        }
        if(col.gameObject.name == "Star")
            if(door2.isKinematic==true)
            door2.isKinematic=false;

        if(col.gameObject.name == "Christmas-Ball")
            if(door3.isKinematic==true)
            door3.isKinematic=false;

        if(col.gameObject.name == "startwo")
            if(door4.isKinematic==true)
            door4.isKinematic=false;
    
    }
}