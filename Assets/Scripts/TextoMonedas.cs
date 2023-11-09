using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextoMonedas : MonoBehaviour
{
    public TextMeshProUGUI textoMonedas;
    void Start()
    {
        DatosJuego datoJuegos = GuardarDatos.CargarDatos();
        int a = datoJuegos.monedasRecolectadas;
        string b = "" + a;
        textoMonedas.SetText(b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
