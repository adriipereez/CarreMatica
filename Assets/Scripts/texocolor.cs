using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditorInternal.ReorderableList;

public class texocolor : MonoBehaviour
{
    // Start is called before the first frame update
    public Image i;
    Color colorPersonalizado = new Color(0.8f, 0.5f, 0.8f);
    Color colorTurquesa = new Color(0.1f, 0.9f, 0.9f);
    Color colorAzulClaro = new Color(0.3f, 0.5f, 1.0f);
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       DatosJuego dj = GuardarDatos.CargarDatos();
        int idcoche = dj.idcoche;
        if (idcoche == -1)
        {
            i.color = Color.black;
        }
        else if (idcoche == 0)
        {
            i.color = Color.green;
        }
        else if (idcoche == 1)
        {
            i.color = colorPersonalizado;
        }
        else if (idcoche == 2)
        {
            i.color = colorAzulClaro;
        }
        else if (idcoche == 3)
        {
            i.color = colorTurquesa;
        }
        else if (idcoche == 4)
        {
            i.color = Color.red;
        }  
    }
}
