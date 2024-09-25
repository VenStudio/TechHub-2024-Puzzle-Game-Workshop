using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalTile : MonoBehaviour
{
    public GameObject[] groundTiles;
    public GameObject winText;
    public GameObject loseText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Reload game
        if(Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    void OnTriggerEnter2D(Collider2D other) {
        // Check if any ground tile is active
        for (int i = 0; i < groundTiles.Length; i++)
        {
            if(groundTiles[i].gameObject.activeInHierarchy)
            {
                // Show lose message if an active tile is found
                loseText.SetActive(true);
                return;
            }
        }

        // If no active tile is found, show win message
        winText.SetActive(true);
    }
}
