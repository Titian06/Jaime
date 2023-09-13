using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaDisparadora : MonoBehaviour
{
    public GameObject bolaPrefab; // Prefab de la bola que se disparará.
    public Transform puntoDisparo; // Punto de origen del disparo.

    public float fuerzaDisparo = 10f; // Fuerza del disparo.

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Verifica si se hizo clic izquierdo.
        {
            Disparar();
        }
    }

    void Disparar()
    {
        // Crea una nueva instancia de la bola desde el prefab.
        GameObject nuevaBola = Instantiate(bolaPrefab, puntoDisparo.position, Quaternion.identity);

        // Accede al Rigidbody de la nueva bola y aplica una fuerza para dispararla.
        Rigidbody rb = nuevaBola.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * fuerzaDisparo, ForceMode.Impulse);
    }
}

