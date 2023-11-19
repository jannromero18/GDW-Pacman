using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int _score = 0;

    private Rigidbody rb;

    [SerializeField] private float _speed;
    private Vector2 _moveDirection;

    void Start(){
        InputManager.Init(this); //puts the game controls on the player
        InputManager.SetGameControls();

        rb = GetComponent<Rigidbody>();


    }
    
    void Update(){
        print("score " + _score);

        transform.position += speed * Time.deltaTime * _moveDirection;
    }

     public void SetMovementDirection(Vector2 currentDirection){
        _moveDirection = currentDirection;
    }
}
