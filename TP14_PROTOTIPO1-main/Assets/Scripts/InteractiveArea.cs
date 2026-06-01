using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveArea : MonoBehaviour
{
    int score = 0;

    UIMANAGER uiManager;

    void Awake()
    {
        uiManager = FindObjectOfType<UIMANAGER>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
            score++;

            uiManager.UpdateScore(score);

            Destroy(other.gameObject);
        }
    }
}
