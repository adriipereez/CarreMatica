using UnityEngine;
using TMPro;
using System.IO;
using UnityEngine.SceneManagement;

public class Marcador : MonoBehaviour
{
    public TextMeshProUGUI textoPuntos;

    private int puntos = 0;
    private int puntMaxima = 0; // Nueva variable para almacenar la puntuación máxima
    private float tiempoAcumulado = 0f;
    private float tiempoEntreSuma = 0.5f;
    private string rutaArchivo;

    void Start()
    {
        rutaArchivo = Application.persistentDataPath + "/puntuacion.txt";

        // Cargar la puntuación almacenada (si existe)
        if (File.Exists(rutaArchivo))
        {
            string datosPuntuacion = File.ReadAllText(rutaArchivo);
            int puntuacionGuardada;
            if (int.TryParse(datosPuntuacion, out puntuacionGuardada))
            {
                puntMaxima = puntuacionGuardada; // Actualizar la puntuación máxima
            }
        }

        ActualizarTextoPuntos(); // Mostrar el marcador con la puntuación actualizada
        SceneManager.sceneUnloaded += GuardarPuntuacionAlCambiarEscena;
    }

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

        if (puntos > puntMaxima)
        {
            puntMaxima = puntos; // Actualizar la puntuación máxima si supera la actual
        }
    }

    void OnDestroy()
    {
        GuardarPuntuacion();
    }

    void GuardarPuntuacionAlCambiarEscena(Scene scene)
    {
        GuardarPuntuacion();
    }

    void GuardarPuntuacion()
    {
        File.WriteAllText(rutaArchivo, puntMaxima.ToString()); // Guardar solo la puntuación máxima
    }

    void ActualizarTextoPuntos()
    {
        textoPuntos.text = "Puntos: " + puntos.ToString();
    }
}
