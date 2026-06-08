using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveArea : MonoBehaviour
{
    int score = 0;

    public int maxScore = 2;

    UIMANAGER uiManager;
    
    GameManager gameManager;

    void Awake()
    {
        uiManager = FindObjectOfType<UIMANAGER>();
        
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
            score++;

            uiManager.UpdateScore(score);

            Destroy(other.gameObject);
        }

        if (score >= maxScore)
            {
                gameManager.EndGame();
            }
    }
}
