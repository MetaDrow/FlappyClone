using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractCharacter : MonoBehaviour
{
    public Rigidbody _rb;
    public float _speed;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        MoveForward();

    }

    private void FixedUpdate()
    {

    }

    void MoveForward()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            var a = new Vector3(0, 1, 0.25f) * _speed;
          //  _rb.AddForce(a * _speed);

            _rb.AddForce(a,ForceMode.Impulse);
        }
    }
}
