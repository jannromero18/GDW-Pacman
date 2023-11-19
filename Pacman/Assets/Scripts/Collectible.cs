using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
   private void OnTriggerEnter(Collider other){ //box collider isTrigger 
        if(other.transform.tag == "Player"){
            Destroy(gameObject); 
            Player.score++;
        }
    } 
}
