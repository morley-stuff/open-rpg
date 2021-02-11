using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 5f;

    [SerializeField]
    private float _gravity = 9.81f;

    [SerializeField]
    private float _jumpSpeed = 3.5f;

    private float verticalSpeed;

    private CharacterController _controller;

    // Start is called before the first frame update
    void Start()
    {
        
        _controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump") && _controller.isGrounded) {
            verticalSpeed = _jumpSpeed;
        }

        verticalSpeed -= _gravity * Time.deltaTime;

        Vector3 direction = new Vector3(horizontalInput, verticalSpeed, verticalInput);

        _controller.Move(direction * _moveSpeed * Time.deltaTime);
        
    }
}
