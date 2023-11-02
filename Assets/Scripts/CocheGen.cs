using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CocheGen : MonoBehaviour
{
    public Sprite[] sprites = new Sprite[13];
    private float vel;


    void Start()
    {
        vel = 5f;
        int numRandom = Random.Range(0,12);
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[numRandom];
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
        Vector2 costatInferiorIzq = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
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
            Vector2 explosionPosition = transform.position;
            GameObject explosion = Instantiate(Resources.Load("Prefabs/Explosion_0") as GameObject);
            explosion.transform.position = explosionPosition;
        }
    }
}
