using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUp : MonoBehaviour
{

    static int objetosRecolectados = 0;

    public TextMeshProUGUI contadorTexto;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
            objetosRecolectados++;

            contadorTexto.text = "Objetos recolectados: " + objetosRecolectados;

            Destroy(other.gameObject);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
