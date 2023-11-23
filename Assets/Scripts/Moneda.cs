using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Asegúrate de agregar esta línea para importar el espacio de nombres TextMeshPro.

public class Moneda : MonoBehaviour
{
    private float vel;

    void Start()
    {
        vel = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 posicion = transform.position;
        posicion.y = posicion.y - vel * Time.deltaTime;
        transform.position = posicion;
        DestuyeSiSaleFuera();
    } 
    
    private void DestuyeSiSaleFuera()
    {
        Vector2 costatInferiorIzq = Camera.main.ViewportToWorldPoint(new Vector2(0, -1));
        if (transform.position.y <= costatInferiorIzq.y)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "F1")
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
            GuardarDatos.incrementarMonedas();
            GameObject.Find("Canvas/TextoMonedas").GetComponent<TextMeshProUGUI>().text = GuardarDatos.cantidadMonedas().ToString();
        }
    }
}
