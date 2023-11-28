using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int _score = 0;

    private Rigidbody2D rb;

    float input;

    [SerializeField] private float _speed;
    public int _maxLives = 3;
    public static int _currentLives;

    void Start(){
        //InputManager.Init(this); //puts the game controls on the player
       // InputManager.SetGameControls();

        rb = GetComponent<Rigidbody2D>();
        _currentLives = _maxLives;

    }
    
    void Update(){
        print("score " + _score);

        if(_currentLives > 0){
            print("lives " + _currentLives);
        }
        else{
            print("Game Over");
        }
        
    }

     void FixedUpdate(){
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

        rb.AddForce (movement * _speed);    
     }
}
