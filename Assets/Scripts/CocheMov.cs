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
    public Sprite nuevoSpriteVerde;
    public Sprite nuevoSpriteMorado;
    public Sprite nuevoSpriteAzul;
    public Sprite nuevoSpriteTurquesa;
    public Sprite nuevoSpriteRojo;
    public Sprite DEFAULT;
    private SpriteRenderer miSpriteRenderer;

    void Start()
    {
        miSpriteRenderer = GetComponent<SpriteRenderer>();
        DatosJuego dj = GuardarDatos.CargarDatos();
        int idcoche = dj.idcoche;
        Sprite spritenuevo = gameObject.GetComponent<SpriteRenderer>().sprite;
        if (idcoche == -1)
        {
            miSpriteRenderer.sprite = DEFAULT;
        }
        else if(idcoche == 0)
        {
            miSpriteRenderer.sprite = nuevoSpriteVerde;
        }
        else if (idcoche == 1)
        {
            miSpriteRenderer.sprite = nuevoSpriteMorado;
        }
        else if (idcoche == 2)
        {
            miSpriteRenderer.sprite = nuevoSpriteAzul;
        }
        else if (idcoche == 3)
        {
            miSpriteRenderer.sprite = nuevoSpriteTurquesa;
        }
        else if (idcoche == 4)
        {
            miSpriteRenderer.sprite = nuevoSpriteRojo;
        }
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
