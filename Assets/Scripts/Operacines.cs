using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Operacines : MonoBehaviour
{
    private string TextoOperacion;
    private int Resultado;
    private Vector2[] posBomba = new Vector2[4];
    public GameObject bomba;
    public bool bombasCreadas = false;


    void Start()
    {
        posBomba[0] = new Vector2(-3.84f, 9.16f);
        posBomba[1] = new Vector2(-1.28f, 9.16f);
        posBomba[2] = new Vector2(1.27f, 9.16f);
        posBomba[3] = new Vector2(3.76f, 9.16f);
        bombasCreadas = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (bombasCreadas == true) {
            if (GameObject.Find("Pizarra").GetComponent<Renderer>().sortingLayerName == "ForeGround") {
                Invoke("InstanciarBombas", 1f);
                bombasCreadas = false;
            }
        }
    }

    public void limpiarPizarra()
    {
        string limpio = "";
        GameObject.Find("TextOperaciones").GetComponent<TMPro.TextMeshPro>().text = limpio;
    }
    public void GenerarOperacion()
    {
        int num1 = Random.Range(1,10);
        int num2 = Random.Range(1, 10);
        int numSigno = Random.Range(1, 4);
        numSigno = 2;
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

    private void InstanciarBombas()
    {
        GameObject bomba1 = Instantiate(bomba);
        GameObject bomba2 = Instantiate(bomba);
        GameObject bomba3 = Instantiate(bomba);
        GameObject bomba4 = Instantiate(bomba);

        bomba1.transform.position = posBomba[0];
        bomba2.transform.position = posBomba[1];
        bomba3.transform.position = posBomba[2];
        bomba4.transform.position = posBomba[3];

        int posIF = Random.Range(0, 4);
        string strResultadoCorrecto = Resultado + "";
        int signo = Random.Range(0, 2);
        int margenError = Random.Range(1, 10);

        if (posIF == 0) { 
            bomba1.GetComponent<Bomb>().SetTextResultat(strResultadoCorrecto);
            bomba1.GetComponent<Bomb>().hacerlaCorrecta();
            GenerarTextErroneo(signo, margenError, bomba2);
            GenerarTextErroneo(signo, margenError, bomba3);
            GenerarTextErroneo(signo, margenError, bomba4);

        } else if (posIF == 1)
        {
            bomba2.GetComponent<Bomb>().SetTextResultat(strResultadoCorrecto);
            bomba2.GetComponent<Bomb>().hacerlaCorrecta();
            GenerarTextErroneo(signo, margenError, bomba1);
            GenerarTextErroneo(signo, margenError, bomba3);
            GenerarTextErroneo(signo, margenError, bomba4);

        } else if(posIF == 2) 
        {
            bomba3.GetComponent<Bomb>().SetTextResultat(strResultadoCorrecto);
            bomba3.GetComponent<Bomb>().hacerlaCorrecta();
            GenerarTextErroneo(signo, margenError, bomba1);
            GenerarTextErroneo(signo, margenError, bomba2);
            GenerarTextErroneo(signo, margenError, bomba4);
        }
        else if (posIF == 3)
        {
            bomba4.GetComponent<Bomb>().SetTextResultat(strResultadoCorrecto);
            bomba4.GetComponent<Bomb>().hacerlaCorrecta();
            GenerarTextErroneo(signo, margenError, bomba1);
            GenerarTextErroneo(signo, margenError, bomba2);
            GenerarTextErroneo(signo, margenError, bomba3);
        }
    }
    private void GenerarTextErroneo(int signo, int margenError, GameObject bomba)
    {
        signo = Random.Range(0, 2);
        margenError = Random.Range(1, 10);

        if (signo == 0)
        {
            bomba.GetComponent<Bomb>().SetTextResultat((Resultado + margenError) + "");
        }
        else
        {
            bomba.GetComponent<Bomb>().SetTextResultat((Resultado - margenError) + "");
        }
    }
}
