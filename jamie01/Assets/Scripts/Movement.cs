using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    [Header("Player Speeds")]
    public float moveSpeed = 5;
    public float crouchSpeed = 2.5f;
    public float walkSpeed = 5;
    public float runSpeed = 10;
    public float jumpSpeed = 8;

    private float gravity = 20;
    private Vector3 moveDir;
    private CharacterController charController;
    void Start()
    {
        charController = GetComponent<CharacterController>();
    }
    void Update()
    {
        if (charController.isGrounded)
        {
            if (Input.GetButton("Sprint"))
            {
                moveSpeed = runSpeed;
            }
            else if (Input.GetButton("Crouch"))
            {
                moveSpeed = crouchSpeed;
            }
            else
            {
                moveSpeed = walkSpeed;
            }
            moveDir = transform.TransformDirection(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * moveSpeed * Time.timeScale);

            if (Input.GetButton("Jump"))
            {
                moveDir.y = jumpSpeed;
            }
        }
        moveDir.y -= gravity * Time.deltaTime;
        //the only line that actually moves us
        charController.Move(moveDir * Time.deltaTime);
    }
}
