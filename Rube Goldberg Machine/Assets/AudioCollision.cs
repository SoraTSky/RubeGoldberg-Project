 using UnityEngine;
 using System.Collections;
 
  //Add t$$anonymous$$s Script Directly to The Death Zone
 public class AudioCollision : MonoBehaviour
 {
     public AudioSource source;    
     void Start ()   
     {
        source = GetComponent<AudioSource> ();
     }        
 
     void OnCollisionEnter (Collision collision)  //Plays Sound Whenever collision detected
     {
        if (collision.gameObject.tag == "Bell"){
            source.Play();
        }
     }
          // Make sure that deathzone has a collider, box, or mesh.. ect..,
          // Make sure to turn "off" collider trigger for your deathzone Area;
          // Make sure That anyt$$anonymous$$ng that collides into deathzone, is rigidbody;
 }