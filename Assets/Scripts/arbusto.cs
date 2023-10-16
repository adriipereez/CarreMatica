using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arbusto : MonoBehaviour
{

        private float vel;

    void Start()
    {
        vel = 5f;
    }

    void Update()
    {
        Vector2 posicion = transform.position;
        posicion.y = posicion.y - vel * Time.deltaTime;
        transform.position = posicion;
        DestuyeSiSaleFuera();
    }

    private void DestuyeSiSaleFuera()
{
    Vector2 costatInferiorIzq = Camera.main.ViewportToWorldPoint(new Vector2(0,0)); 
    if (transform.position.y <= costatInferiorIzq.y) {
        Destroy(gameObject);
    }
}

}

