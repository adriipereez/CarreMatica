using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Marcador : MonoBehaviour
{
    public TextMeshProUGUI textoPuntos; 

    private int puntos = 0;
    private float tiempoAcumulado = 0f;
    private float tiempoEntreSuma = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempoAcumulado += Time.deltaTime;

        if (tiempoAcumulado >= tiempoEntreSuma)
        {
            SumarPuntos();
            tiempoAcumulado = 0f;
        }
    }
    void SumarPuntos()
    {
        puntos += 50;
        textoPuntos.text = "Puntos: " + puntos.ToString();
    }
}
