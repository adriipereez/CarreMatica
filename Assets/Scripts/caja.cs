using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class caja : MonoBehaviour
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
            GameObject.Find("GeneradorMonedas").GetComponent<GeneradorMonedas>().CancelarGeneradorMonedas();
            GameObject.Find("GeneradorCoches").GetComponent<GeneradorCoches>().CancelarGeneradorCoche();
            GameObject.Find("GeneradorPR").GetComponent<GeneradorCaja>().CancelarGeneradorCaja();
            GameObject[] CochesPresentes = GameObject.FindGameObjectsWithTag("Cochepref");
            for(int i = 0;  i < CochesPresentes.Length; i++)
            {
                Destroy(CochesPresentes[i]);
            }
            GameObject[] Monedaspresentes = GameObject.FindGameObjectsWithTag("Moneda");
            for (int i = 0; i < Monedaspresentes.Length; i++)
            {
                Destroy(Monedaspresentes[i]);
            }
            GameObject.Find("Pizarra").GetComponent<Renderer>().sortingLayerName = "ForeGround";
            GameObject.Find("TextOperaciones").GetComponent<Operacines>().GenerarOperacion();
            GameObject.Find("TextOperaciones").GetComponent<Operacines>().bombasCreadas=true;
        }
    }
}
