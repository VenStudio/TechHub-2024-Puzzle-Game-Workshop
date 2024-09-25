using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Create the variable
        Vector3 movementDirection = Vector3.zero;

        // Calculate the movement
        if(Input.GetKeyDown(KeyCode.W))
            movementDirection.y = 1;
        else if(Input.GetKeyDown(KeyCode.S))
            movementDirection.y = -1;
        else if(Input.GetKeyDown(KeyCode.D))
            movementDirection.x = 1;
        else if(Input.GetKeyDown(KeyCode.A))
            movementDirection.x = -1;

        if (movementDirection != Vector3.zero)
        {
            // Check if the target position has a ground tile
            Vector3 targetPosition = transform.position + movementDirection;

            bool isGround = Physics2D.OverlapCircle(targetPosition, 0.1f);

            if (isGround)
            {
                // Set player position to the target position
                transform.position += movementDirection;
            }
        }
    }
}
