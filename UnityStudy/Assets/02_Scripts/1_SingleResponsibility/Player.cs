using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingleResponsibility
{
    public class Player : MonoBehaviour
    {
        public float MoveSpeed = 5f;
        public float RotationSpeed = 10f;

        private void Update()
        {
            Move();
            Rotate();
        }

        private void Move()
        {
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");
            Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;
            transform.position += moveDirection * MoveSpeed * Time.deltaTime;
        }

        private void Rotate()
        {
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");
            Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;

            if (moveDirection.sqrMagnitude > 0.01f)
            {
                Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, RotationSpeed * Time.deltaTime);
            }
        }
    }
}
