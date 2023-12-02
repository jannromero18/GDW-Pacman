using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int _score = 0;

    private Rigidbody2D rb;
    [SerializeField] private Rigidbody myBullet;

    [SerializeField] private float _speed;
    private Vector2 _moveDirection;

    public int _maxLives = 3;
    public static int _currentLives;

    void Start(){
        InputManager.Init(this); //puts the game controls on the player
        InputManager.SetGameControls();

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
        rb.AddForce (_moveDirection * _speed); 

     }

     public void SetMovementDirection(Vector2 currentDirection){
        _moveDirection = currentDirection;
    }

    public void Shoot(Vector2 currentDirection){
        Instantiate(myBullet, currentDirection, Quaternion.identity);
    }

}
