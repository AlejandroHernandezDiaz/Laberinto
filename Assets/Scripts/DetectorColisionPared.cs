using UnityEngine;

public class DetectorColisionPared : MonoBehaviour
{
    [SerializeField]
    Material MaterialPorDefecto;

    [SerializeField]
    Material MaterialParedTocada;

    bool paredRoja = false;

    float tiempoEnRojo = 5f;

    //Funcion que se ejecuta por cada imagen del juego
    private void Update() 
    { 
        if (paredRoja == true)
        {
            tiempoEnRojo = tiempoEnRojo - Time.deltaTime;
            if(tiempoEnRojo < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = MaterialPorDefecto;
                paredRoja = false;
                tiempoEnRojo = 5f;
            }
        }
    }

    //funcion que se ejecuta al chocar un objeto con este gameObject.
    private void OnCollisionEnter(Collision col)
    {
       

        if (col.gameObject.tag == "Player")
        {
            gameObject.GetComponent<MeshRenderer>().material = MaterialParedTocada;
            paredRoja = true;
        }
    }
}
