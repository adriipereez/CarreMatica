using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BTColores : MonoBehaviour
{

    public int id;

    void Start()
    {
        if (GuardarDatos.MirarSiEstaComprado(id))
        {
            gameObject.SetActive(false);
        }
    }

    void Update()
    {
        
    }

    public void comprarCoche0()
    { 
        if (GuardarDatos.ComprarCoche(id))
        {
            gameObject.SetActive(false);
        }
    }
}
