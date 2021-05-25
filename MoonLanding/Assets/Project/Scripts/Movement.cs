using System;
using UnityEngine;

namespace Project.Scripts
{
    public class Movement : MonoBehaviour
    {
        private float _horizontal;
        private float _vertical;

        private float _xMovement;
        private float _yMovement;
        
        private int _speed = 10;


        private void FixedUpdate()
        {
            Move();
        }

        private void Update()
        {
            Inpts();
        }
        
        private void Inpts()
        {
            _horizontal = Input.GetAxis("Horizontal");
            _vertical = Input.GetAxis("Vertical");
        }

        private void Move()
        {
            _xMovement = _horizontal * _speed * Time.deltaTime;
            _yMovement = _vertical * _speed * Time.deltaTime;

        }

        
    }
}
