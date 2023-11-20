using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorMonedas : MonoBehaviour
{
    private Vector2[] carriles = new Vector2[4];

    public GameObject bronze_coin;
    void Start()
    {
        carriles[0] = new Vector2(-3.84f, 9.16f);
        carriles[1] = new Vector2(-1.28f, 9.16f);
        carriles[2] = new Vector2(1.27f, 9.16f);
        carriles[3] = new Vector2(3.76f, 9.16f);

        InvokeRepeating("Moneda", 2f, 5f);
    }

    void Update()
    {
        
    }

    private void Moneda()
    {
        GameObject Moneda = Instantiate(bronze_coin);
        int a = Random.Range(0, carriles.Length);
        Moneda.transform.position = carriles[a];
    }
}