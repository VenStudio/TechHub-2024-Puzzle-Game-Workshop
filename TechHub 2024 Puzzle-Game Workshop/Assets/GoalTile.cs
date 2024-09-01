using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GoalTile : MonoBehaviour
{
    public GameObject groundTiles;

    void OnTriggerEnter2D(Collider2D other) {
        for (int i = 0; i < groundTiles.transform.childCount; i++)
        {
            if(groundTiles.transform.GetChild(i).gameObject.activeInHierarchy)
            {
                print("There are ground tiles left, You lost..");
                return;
            }
        }

        print("No ground tiles left, You win!");
    }
}
