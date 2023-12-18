using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMBIARCOLORES : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void botonverde()
    {
        DatosJuego dj = GuardarDatos.CargarDatos();
        dj.idcoche = 0;
        GuardarDatos.GuardarDatos2(dj);
    }
    public void rojo()
    {
        DatosJuego dj = GuardarDatos.CargarDatos();
        dj.idcoche = 4;
        GuardarDatos.GuardarDatos2(dj);
    }
    public void morado()
    {
        DatosJuego dj = GuardarDatos.CargarDatos();
        dj.idcoche = 1;
        GuardarDatos.GuardarDatos2(dj);
    }
    public void azul()
    {
        DatosJuego dj = GuardarDatos.CargarDatos();
        dj.idcoche = 2;
        GuardarDatos.GuardarDatos2(dj);
    }
    public void btturqueas()
    {
        DatosJuego dj = GuardarDatos.CargarDatos();
        dj.idcoche = 3;
        GuardarDatos.GuardarDatos2(dj);
    }
    public void DEFAULT()
    {
        DatosJuego dj = GuardarDatos.CargarDatos();
        dj.idcoche = -1;
        GuardarDatos.GuardarDatos2(dj);
    }
}
