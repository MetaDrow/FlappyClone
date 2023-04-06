using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

internal class AbstractCharacter : MonoBehaviour
{
    [SerializeField] Rigidbody _rb;
    [SerializeField] float _impulse;
    [SerializeField] float _gravityScale;
    [SerializeField] float _forwardMove;

    public event EventHandler OnSpacePressed;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }


    void Update()
    {

    }
    

    private void FixedUpdate()
    {
        MoveForward();
        Gravity();
    }

    void MoveForward()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            var a = new Vector3(0, 1, _forwardMove) * _impulse;
            //  _rb.AddForce(a * _speed);
            _rb.AddForce(a, ForceMode.Impulse);
        }
    }

    void Gravity()
    {
        Physics.gravity = new Vector3(0, -_gravityScale, 0);
    }
}
