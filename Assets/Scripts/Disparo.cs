using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
 
    public GameObject balaPrefab;
    public float enfriamientoDisparo= 0.25f;
    float tiempoUltimoDisparo = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DisparoArma();
        }
    }

    void DisparoArma()
    {
        if(Time.time - tiempoUltimoDisparo > enfriamientoDisparo)
        {
            GameObject.Instantiate(balaPrefab, transform.position, transform.rotation);
            tiempoUltimoDisparo = Time.time;
        }
    }
}