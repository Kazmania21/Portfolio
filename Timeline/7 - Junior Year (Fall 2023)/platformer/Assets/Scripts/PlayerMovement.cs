using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private bool spacePressed = false;
    private float verticalInput = 0.0f;
    private float horizontalInput = 0.0f;
    private Rigidbody rigidBodyComponent;
    private bool isGrounded = true;
    [SerializeField] private Transform groundCheckTransform; 
    [SerializeField] private LayerMask playerMask;

    public float test;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    public float speedH = 2.0f;
    public float speedV = 2.0f;
    Vector3 horizontalMovement;
    Vector3 verticalMovement;

    // Start is called before the first frame update
    void Start()
    {
        rigidBodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        test = transform.rotation.y;

        if (Input.GetKeyDown(KeyCode.Space)) {
            if (isGrounded) {
                spacePressed = true;
            }
        }

        if (Input.GetKeyDown("escape")) {
            Application.Quit();
        }

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
    }

    // Updates 100 times per second
    void FixedUpdate(){
        if (spacePressed) {
            rigidBodyComponent.AddForce(Vector3.up * 6f, ForceMode.VelocityChange);
            spacePressed = false;
        }

        transform.eulerAngles = new Vector3 (0, yaw, 0.0f);

        if (rigidBodyComponent.velocity.z <= 10 && rigidBodyComponent.velocity.z >= -10) {
            verticalMovement = new Vector3(0, 0f, verticalInput * 8);        // Multiplier of 8 seems to work well with Rigidbody Mass of 1.
            
        }

        else {
            verticalMovement = new Vector3(0, 0f, -verticalInput * 9);
        }

        verticalMovement = transform.TransformDirection(verticalMovement);
        rigidBodyComponent.AddForce(verticalMovement * 2);

        if (rigidBodyComponent.velocity.x <= 10 && rigidBodyComponent.velocity.x >= -10) {
            horizontalMovement = new Vector3(horizontalInput * 8, 0f, 0);        // Multiplier of 8 seems to work well with Rigidbody Mass of 1.            
        }

        else {
            horizontalMovement = new Vector3(0, 0f, 0);        // Multiplier of 8 seems to work well with Rigidbody Mass of 1.
        }

        horizontalMovement = transform.TransformDirection(horizontalMovement);
        rigidBodyComponent.AddForce(horizontalMovement * 2);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entered");
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exited");
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
