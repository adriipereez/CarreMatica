using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Bomb : MonoBehaviour
{
    private bool esCorrecta = false;
    private float vel = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DestuyeSiSaleFuera();
        Vector2 pos = transform.position;
        pos = new Vector2 (pos.x, pos.y - vel * Time.deltaTime);
        transform.position = pos;
    }

    private void DestuyeSiSaleFuera()
    {
        Vector2 costatInferiorIzq = Camera.main.ViewportToWorldPoint(new Vector2(0, -1));
        if (transform.position.y <= costatInferiorIzq.y)
        {
            Destroy(gameObject);
        }
    }

    public void hacerlaCorrecta() {
        esCorrecta = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "F1")
        {
            if (esCorrecta)
            {
                GameObject.Find("Pizarra").GetComponent<Renderer>().sortingLayerName = "Pizarrareserva";
                GameObject.Find("TextOperaciones").GetComponent<Operacines>().limpiarPizarra();
                Destroy(gameObject);
                Vector2 explosionPosition = transform.position;
                GameObject explosion = Instantiate(Resources.Load("Prefabs/Explosion_0") as GameObject);
                explosion.transform.position = explosionPosition;
                GameObject.Find("GeneradorMonedas").GetComponent<GeneradorMonedas>().IniciarGeneradorMonedas();
                GameObject.Find("GeneradorCoches").GetComponent<GeneradorCoches>().IniciarGeneradorCoches();
                GameObject.Find("GeneradorPR").GetComponent<GeneradorCaja>().IniciarGeneradorCaja();

            }
            else {
                
                other.gameObject.SetActive(false);
                Vector2 explosionPosition = transform.position;
                GameObject explosion = Instantiate(Resources.Load("Prefabs/Explosion_0") as GameObject);
                explosion.transform.position = explosionPosition;
                Vector2 explosionPosition2 = other.transform.position;  
                GameObject explosio2 = Instantiate(Resources.Load("Prefabs/Explosion_0") as GameObject);
                explosio2.transform.position = explosionPosition2;
                Destroy(other);
                gameObject.SetActive(false);
                Invoke("final", 1f);

            }
        }
    }

    public void SetTextResultat(string resultat)
    {
        GetComponentInChildren<TMPro.TextMeshPro>().text=resultat;
    }

    void final()
    {
        SceneManager.LoadScene("Final");
        Destroy(gameObject);
    }
}
