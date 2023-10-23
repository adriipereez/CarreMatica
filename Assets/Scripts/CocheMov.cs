using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CocheMov : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;

    public string Menu;
    void Start()
    {
       
    }
    void Update()
    {
 
        float movimientoHorizontal = Input.GetAxis("Horizontal"); 

        float desplazamiento = movimientoHorizontal * velocidadMovimiento * Time.deltaTime;

        transform.Translate(Vector2.right * desplazamiento);
        Vector2 novaPos = transform.position;
        novaPos.x = Mathf.Clamp(novaPos.x,-4.25f,4.25f);
        transform.position = novaPos;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CambiarEscena();
        }
    }
    void CambiarEscena()
    {
        SceneManager.LoadScene("Menu");
    }
}
