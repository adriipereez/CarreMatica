using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonVerde : MonoBehaviour
{

    void Start()
    {
        if (GuardarDatos.MirarSiEstaComprado(0))
        {
              // Mostrar boton de seleccionar
        }
        else { 

        }   
    }


    void Update()
    {
        
    }

    public void comprarCoche0() 
    {
        GuardarDatos.ComprarCoche(0);
        if (GuardarDatos.ComprarCoche(0))
        {
            gameObject.SetActive(false);   
        }
   
    }
    public void comprarCoche1()
    {

    }
    public void comprarCoche2()
    {

    }
    public void comprarCoche3()
    {

    }
    public void comprarCoche4()
    {

    }

}
