using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int _score = 0;

    private Rigidbody2D rb;
    //[SerializeField] private Rigidbody2D myBullet;

    [SerializeField] private float _speed;
    private Vector2 _moveDirection;
    private Vector2 mousePosition;

    //[SerializeField] private float _bulletSpeed;
    public Weapon weapon;

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
        
        if(Input.GetMouseButtonDown(0)){
            weapon.Fire();
        }
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

     void FixedUpdate(){
        rb.AddForce (_moveDirection * _speed); 
        Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;
     }

     public void SetMovementDirection(Vector2 currentDirection){
        _moveDirection = currentDirection;
    }
}
