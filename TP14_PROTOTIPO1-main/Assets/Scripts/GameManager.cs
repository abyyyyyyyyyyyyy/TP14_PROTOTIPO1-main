using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timer = 60f;

    UIMANAGER uiManager;

    void Awake()
    {
        uiManager = FindObjectOfType<UIMANAGER>();
    }

    void Update()
    {
        timer -= Time.deltaTime;
        uiManager.UpdateTimer(timer);
    }
    
}
