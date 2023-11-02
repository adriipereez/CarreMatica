using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorCoches : MonoBehaviour
{
    private Vector2[] carriles = new Vector2[4];
    public GameObject PrefabCoches;
    // Start is called before the first frame update
    void Start()
    {
        carriles[0] = new Vector2(-3.84f, 9.16f);
        carriles[1] = new Vector2(-1.28f, 9.16f);
        carriles[2] = new Vector2(1.27f, 9.16f); 
        carriles[3] = new Vector2(3.76f, 9.16f);

        InvokeRepeating("GenerarCoche", 2f, 1f);
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
}
