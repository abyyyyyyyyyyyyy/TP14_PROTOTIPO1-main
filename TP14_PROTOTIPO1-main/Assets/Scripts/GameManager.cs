using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timer = 60f;

    UIMANAGER uiManager;

    bool gameOver = false;

    void Awake()
    {
        uiManager = FindObjectOfType<UIMANAGER>();
    }

    void Update()
    {
        if (gameOver)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

            return;
        }

        timer -= Time.deltaTime;
        uiManager.UpdateTimer(timer);

        if (timer <= 0)
        {
            gameOver = true;

            uiManager.MostrarPantallaGameOver();
        }
    }

    public void EndGame()
    {
        gameOver = true;

        uiManager.MostrarPantallaWin();

    }
    
}
