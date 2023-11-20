using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int _score = 0;

    private Rigidbody2D rb;

    float input;

    [SerializeField] private float _speed;

    void Start(){
        //InputManager.Init(this); //puts the game controls on the player
       // InputManager.SetGameControls();

        rb = GetComponent<Rigidbody2D>();


    }
    
    void Update(){
        print("score " + _score);
    }

     void FixedUpdate(){
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

        rb.AddForce (movement * _speed);    
     }
}
