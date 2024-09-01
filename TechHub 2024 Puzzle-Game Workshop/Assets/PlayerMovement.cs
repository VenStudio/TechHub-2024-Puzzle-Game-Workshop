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
        if(Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        Vector3 detector = transform.position;


        if(Input.GetKeyDown(KeyCode.W))
            detector += new Vector3(0, 1);
        if(Input.GetKeyDown(KeyCode.S))
            detector += new Vector3(0, -1);
        if(Input.GetKeyDown(KeyCode.A))
            detector += new Vector3(-1, 0);
        if(Input.GetKeyDown(KeyCode.D))
            detector += new Vector3(1, 0);

        bool isGround = Physics2D.OverlapCircle(detector, 0.1f, LayerMask.GetMask("Ground"));

        if(isGround)
        {
            transform.position = detector;
        }
    }
}
