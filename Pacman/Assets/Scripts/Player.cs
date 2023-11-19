using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int _score = 0;

    private Rigidbody rb;

    [SerializeField] private float _speed;

    void Start(){
        InputManager.Init(this); //puts the game controls on the player
        InputManager.SetGameControls();

        rb = GetComponent<Rigidbody>();


    }
    
    void Update(){
        print("score " + _score);

    }

}
