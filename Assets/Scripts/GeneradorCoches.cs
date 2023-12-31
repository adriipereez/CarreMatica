using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorCoches : MonoBehaviour
{
    private Vector2[] carriles = new Vector2[4];
    public GameObject PrefabCoches;
    void Start()
    {
        carriles[0] = new Vector2(-3.84f, 9.16f);
        carriles[1] = new Vector2(-1.28f, 9.16f);
        carriles[2] = new Vector2(1.27f, 9.16f); 
        carriles[3] = new Vector2(3.76f, 9.16f);

        IniciarGeneradorCoches();
    }
    private void GenerarCoche()
    {
        GameObject CocheGenerico = Instantiate(PrefabCoches);
        int a = Random.Range(0, carriles.Length);
        CocheGenerico.transform.position = carriles[a];

    }
    // Update is called once per frame
    void Update()
    {
      
    }
    public void IniciarGeneradorCoches()
    {
        InvokeRepeating("GenerarCoche", 1f, 1f);
    }

    public void CancelarGeneradorCoche()
    {
        CancelInvoke("GenerarCoche");
    }

}
