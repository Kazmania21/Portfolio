using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryCondition : MonoBehaviour
{
    public Vector3 spawnPosition = new Vector3(0, 0, 0);
    private Camera playerCamera;

    void Start() {
        playerCamera = (Camera) GameObject.FindObjectOfType(typeof(Camera));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y <= -50) {
            transform.position = spawnPosition;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entered");
        if (collision.gameObject.CompareTag("Victory"))
        {
            GameObject.Find("Victory").GetComponent<Text>().enabled = true;
        }
    }
}
