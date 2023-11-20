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

    public static void incrementarMonedas() {
        DatosJuego dj = CargarDatos();
        dj.monedasRecolectadas++;
        GuardarDatos2(dj);
    }

    public static void eliminarMonedas(int x) {
        DatosJuego dj = CargarDatos();
        dj.monedasRecolectadas-=x;
        GuardarDatos2(dj);
    }

    public static int cantidadMonedas() {
        DatosJuego dj = CargarDatos();
        return dj.monedasRecolectadas;
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
            dj.monedasRecolectadas = 0;
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
