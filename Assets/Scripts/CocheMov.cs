using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

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

         
        if (Input.GetKeyDown(KeyCode.Space))
        {
            velocidadMovimiento = 10;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            velocidadMovimiento = 5;
        }
        

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CambiarEscena();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Cochepref")
        {
            Invoke("final", 1f);
            gameObject.SetActive(false);
            Vector2 explosionPosition = transform.position;
            GameObject explosion = Instantiate(Resources.Load("Prefabs/Explosion_0") as GameObject);
            explosion.transform.position = explosionPosition;

        }
    }

    void CambiarEscena()
    {
        SceneManager.LoadScene("Menu");
    }
    void final()
    {
        SceneManager.LoadScene("Final");
        Destroy(gameObject);
    }
}
