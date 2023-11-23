using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorCaja : MonoBehaviour
{
    private Vector2[] carriles = new Vector2[4];

    public GameObject caja_Opraciones;
    void Start()
    {
        carriles[0] = new Vector2(-3.84f, 9.16f);
        carriles[1] = new Vector2(-1.28f, 9.16f);
        carriles[2] = new Vector2(1.27f, 9.16f);
        carriles[3] = new Vector2(3.76f, 9.16f);

        InvokeRepeating("caja", 2f, 5f);
    }

    void Update()
    {

    }

    private void caja()
    {
        GameObject caja = Instantiate(caja_Opraciones);
        int a = Random.Range(0, carriles.Length);
        caja.transform.position = carriles[a];
    }

    public void IniciarGeneradorCaja()
    {
        InvokeRepeating("caja", 2f, 5f);
    }

    public void CancelarGeneradorCaja()
    {
        CancelInvoke("caja");
    }
}
