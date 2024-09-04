using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GoalTile : MonoBehaviour
{
    public GameObject[] groundTiles;
    public GameObject winText;
    public GameObject loseText;

    void OnTriggerEnter2D(Collider2D other) {
        for (int i = 0; i < groundTiles.Length; i++)
        {
            if(groundTiles[i].gameObject.activeInHierarchy)
            {
                loseText.SetActive(true);
                return;
            }
        }

        winText.SetActive(true);
    }
}
