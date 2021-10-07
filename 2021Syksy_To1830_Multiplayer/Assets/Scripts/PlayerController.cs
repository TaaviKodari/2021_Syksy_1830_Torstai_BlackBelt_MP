using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController controller;
    public float moveSpeed = 8f;
    public float runSpeed = 14f;
    public float jumpHeight = 3f;
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.1f;
    public LayerMask groundMask;

    [SerializeField] private bool isGrounded;
    
    private Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfGrounded();
    }

    private void CheckIfGrounded()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position,groundDistance, groundMask);

        if(isGrounded)
        {
            velocity.y = -2;
        }

        velocity.y +=  gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
