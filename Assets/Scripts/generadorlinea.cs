using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generadorlinea : MonoBehaviour
{

    public GameObject PrefabLinea;


 private void GenerarLinea()
 {
     GameObject linea = Instantiate(PrefabLinea);
     linea.transform.position = new Vector2(0, 5);
     
 }

 private void GenerarLinea1()
 {
     GameObject linea = Instantiate(PrefabLinea);
     linea.transform.position = new Vector2(0, 5);
     
 }

 private void GenerarLinea2()
 {
     GameObject linea = Instantiate(PrefabLinea);
     linea.transform.position = new Vector2(-1.7f, 5);
     
 }
  private void GenerarLinea3()
 {
     GameObject linea = Instantiate(PrefabLinea);
     linea.transform.position = new Vector2(1.7f, 5);
     
 }
   private void GenerarLinea4()
 {
     GameObject linea = Instantiate(PrefabLinea);
     linea.transform.position = new Vector2(-5.1f, 5);
     
 }
    void Start()
    {
        InvokeRepeating("GenerarLinea", 0f, 0.5f);
        InvokeRepeating("GenerarLinea1", 0f, 0.5f);
        InvokeRepeating("GenerarLinea2", 0f, 0.5f);
        InvokeRepeating("GenerarLinea3", 0f, 0.5f);
        InvokeRepeating("GenerarLinea4", 0f, 0.5f);
    }

    void Update()
    {
        
    }
}
