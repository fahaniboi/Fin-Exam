using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public GameObject Floor;

    private Vector3 FloorNorm;

    void Start()
    {
        FloorNorm = Floor.transform.up;
    }

    void Update()
    {       
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0f, verticalInput);

        if (movementDirection != Vector3.zero)
        {
            movementDirection = Vector3.ProjectOnPlane(movementDirection, FloorNorm).normalized;

            transform.position += movementDirection * speed * Time.deltaTime;
        }
    }
}
