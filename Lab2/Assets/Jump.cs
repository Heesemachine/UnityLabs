using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]

public class Jump : MonoBehaviour
{
    public float jumpSpeed = 550.0f;
    private bool canJump = true;
    private bool isJumping = false;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    float movementSpeed;

    void Update()
    {
        float amountToMove = movementSpeed * Time.deltaTime;
        Vector3 movement = (Input.GetAxis("Horizontal") * -Vector3.left * amountToMove) + (Input.GetAxis("Vertical") * Vector3.forward * amountToMove);
        rb.AddForce(movement, ForceMode.Force);

        if (Input.GetKeyDown("space") && canJump && !isJumping) 
        {
            rb.AddForce(Vector3.up * jumpSpeed);
            canJump = false;
            isJumping = true; 
        }
    }

    void OnCollisionStay()
    {
        canJump = true;
        isJumping = false; 
    }
}
