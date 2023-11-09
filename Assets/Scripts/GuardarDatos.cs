using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class GuardarDatos : MonoBehaviour
{
    private static string rutaArchivo = "Monedas.obj";

    private void Start()
    {
        CargarDatos();
    }
    public static DatosJuego CargarDatos()
    {
        if (File.Exists(rutaArchivo))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream file = File.Open(rutaArchivo, FileMode.Open);

            DatosJuego datos = (DatosJuego)formatter.Deserialize(file);
            file.Close();
            return datos;
        }
        else {
            DatosJuego dj = new DatosJuego();
            dj.monedasRecolectadas = 10;
            GuardarDatos2(dj);
        }
        return null;
    }

    public static void GuardarDatos2 (DatosJuego datos)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream file = File.Create(rutaArchivo);

        formatter.Serialize(file, datos);
        file.Close();
    }

    
}
