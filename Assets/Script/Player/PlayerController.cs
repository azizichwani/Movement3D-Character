using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TankU.PlayerInput;

namespace TankU.Player{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float playerSpeed;
        [SerializeField] private float rotateSpeed;
        [SerializeField] private InputController inputController;
        [SerializeField] private Transform tankHead;
        [SerializeField] private Transform tankBody;

        private CharacterController controller;
        private Vector3 _currentLooking = Vector3.zero;
        private Vector3 velocity;
        private Rigidbody rigidbody;

        private void Awake()
        {
            //controller = gameObject.GetComponent<CharacterController>();
            rigidbody = gameObject.GetComponent<Rigidbody>();

        }

        private void Update()
        {
            Vector3 _moveInput = inputController.MoveInput();
            //controller.Move(playerSpeed * Time.fixedDeltaTime * _moveInput);
            //Vector3 dir = _moveInput.normalized;
            //Vector3 velocity = _moveInput * playerSpeed * Time.fixedDeltaTime;
            //transform.Translate(velocity);
            rigidbody.velocity = _moveInput * playerSpeed * Time.deltaTime;

            tankHead.Rotate(inputController.RotateInput() * rotateSpeed);
            if (_currentLooking != _moveInput)
            {
                transform.rotation = Quaternion.LookRotation(_moveInput);
                //tankHead.rotation = Quaternion.LookRotation(_moveInput);
            }

        }
    }
}
