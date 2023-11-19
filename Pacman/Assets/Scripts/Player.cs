using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int score = 0;

    private Rigidbody rb;

    void Start(){
        rb = GetComponent<Rigidbody>();

        
    }
    
    void Update(){
        print("score " + score);
    }
}
