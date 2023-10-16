using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorArbustos : MonoBehaviour
{

public GameObject PrefabArbusto;

 private void GenerarArbustos()
 {
     GameObject arbusto = Instantiate(PrefabArbusto);
     arbusto.transform.position = new Vector2(-6, 11);
     
 }

 private void GenerarArbustos1()
 {
     GameObject arbusto = Instantiate(PrefabArbusto);
     arbusto.transform.position = new Vector2(6, 11);
 }
    void Start()
    {
        InvokeRepeating("GenerarArbustos", 0f, 1);
        InvokeRepeating("GenerarArbustos1", 0f, 1);
    }

    void Update()
    {

    }
}

