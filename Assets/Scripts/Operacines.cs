using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operacines : MonoBehaviour
{
    private string TextoOperacion;
    private int Resultado;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerarOperacion()
    {
        int num1 = Random.Range(1,10);
        int num2 = Random.Range(1, 10);
        int numSigno = Random.Range(1, 3);
        
        if (numSigno==1)
        {
            TextoOperacion = num1 + " + " + num2;
            Resultado = num1 + num2;
            
        } else if (numSigno==2)
        {
            TextoOperacion = num1 + " - " + num2;
            Resultado = num1 - num2;
        } else if (numSigno == 3)
        {
            TextoOperacion = num1 + " X " + num2;
            Resultado = num1 * num2;
        }
        GameObject.Find("TextOperaciones").GetComponent<TMPro.TextMeshPro>().text = TextoOperacion;
    }
}
