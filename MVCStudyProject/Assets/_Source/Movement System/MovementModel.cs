using System;
using UnityEngine;

namespace MovementSystem
{
    public class MovementModel
    {
        private Rigidbody2D _rigidbody;
        private int _movementSpeed;

        public MovementModel(Rigidbody2D rigidbody, int movementSpeed)
        {
            _movementSpeed = movementSpeed;
            _rigidbody = rigidbody;
        }

        public event Action OnMovementStarted;
        public event Action OnMovementStoped;

        public void SetMovementDirection(Vector2 movementDirection)
        {
            movementDirection.Normalize();
            Vector2 movementVelocity = movementDirection * _movementSpeed;
            _rigidbody.velocity = movementVelocity;

            if (movementVelocity.magnitude > 0 )
            {
                OnMovementStarted?.Invoke();
            }
            else
            {
                OnMovementStoped?.Invoke();
            }
        }


    }
}