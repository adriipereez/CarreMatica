using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonSTART : MonoBehaviour
{
public void cargarEscenaJuego()
    {
        SceneManager.LoadScene("EscenaJuego");
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    
}
