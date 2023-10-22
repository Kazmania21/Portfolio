using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisingPlatformMovement : MonoBehaviour
{
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private Rigidbody rigidBodyComponent;
    private Vector3 originalVelocity;
    private Vector3 originalAngularVelocity;

    void Start() {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
        rigidBodyComponent = GetComponent<Rigidbody>();
        originalVelocity = rigidBodyComponent.velocity;
        originalAngularVelocity = rigidBodyComponent.angularVelocity;
    }

    void FixedUpdate()
    {
        transform.position += new Vector3(0, .1f, 0);
        //rigidBodyComponent.AddForce(0, 2, 0);
        if (transform.position.y > 50) {
            transform.position = originalPosition;
            transform.rotation = originalRotation;
            rigidBodyComponent.velocity = originalVelocity;
            rigidBodyComponent.angularVelocity = originalAngularVelocity;
        }
    }
}
