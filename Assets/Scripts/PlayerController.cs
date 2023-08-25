using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    void Start()
    {

    }
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        float verticalMovement = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
        
        transform.Translate(horizontalMovement, 0, verticalMovement);
        
    }

}
