using UnityEngine;
using TMPro;
using System.IO;

public class MostrarPuntuacion : MonoBehaviour
{
    public TextMeshProUGUI textoPuntuacion;

    private void Start()
    {
        MostrarPuntuacionGuardada();
    }

    void MostrarPuntuacionGuardada()
    {
        string rutaArchivo = Application.persistentDataPath + "/puntuacion.txt";

        if (File.Exists(rutaArchivo))
        {
            string datosPuntuacion = File.ReadAllText(rutaArchivo);
            int puntuacionGuardada;
            if (int.TryParse(datosPuntuacion, out puntuacionGuardada))
            {
                textoPuntuacion.text = puntuacionGuardada.ToString();
            }
        }
        else
        {
            textoPuntuacion.text = "Puntuación Guardada: No Disponible";
        }
    }
}
