using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIMANAGER : MonoBehaviour
{
    public TextMeshProUGUI puntajeTexto;
    public TextMeshProUGUI tiempoTexto;
    
    public GameObject Panel_Win;
    public GameObject Panel_GameOver;

    void Start()
    {
        puntajeTexto.text = "Score: 0";
    }

    public void UpdateScore(int score)
    {
        puntajeTexto.text = "Score: " + score;
    }

    public void UpdateTimer(float timer)
    {
        tiempoTexto.text = "Time: 00:" + Mathf.Ceil(timer);
    }

    public void MostrarPantallaWin()
    {
        Panel_Win.SetActive(true);
    }

    public void MostrarPantallaGameOver()
    {
        Panel_GameOver.SetActive(true);
    }
}
