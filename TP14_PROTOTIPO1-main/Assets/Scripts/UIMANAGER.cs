using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIMANAGER : MonoBehaviour
{
    void Start()
    {
        puntajeTexto.text = "Score: 0";
    }

    public TextMeshProUGUI puntajeTexto;
    public TextMeshProUGUI tiempoTexto;

    public void UpdateScore(int score)
    {
        puntajeTexto.text = "Score: " + score;
    }

    public void UpdateTimer(float timer)
    {
        tiempoTexto.text = "Time: 00:" + Mathf.Ceil(timer);
    }


}
