using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // reload game
        if(Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        Vector3 tileDetector = Vector3.zero;

        // Calculate the movement
        if(Input.GetKeyDown(KeyCode.W))
            tileDetector.y = 1;
        if(Input.GetKeyDown(KeyCode.S))
            tileDetector.y = -1;
        if(Input.GetKeyDown(KeyCode.D))
            tileDetector.x = 1;
        if(Input.GetKeyDown(KeyCode.A))
            tileDetector.x = -1;

        if (tileDetector != Vector3.zero)
        {
            // Check if the target position has a ground tile
            bool isGround = Physics2D.OverlapCircle(transform.position + tileDetector, 0.1f, LayerMask.GetMask("Ground"));

            if (isGround)
            {
                // Set player position to the target position
                transform.position += tileDetector;
            }
        }
    }
}
