using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate: MonoBehaviour
{
    public Transform center; // Referencia al centro del objeto sobre el que debe girar.

    public float speed = 60.0f; // Velocidad de rotación en grados por segundo.

    private void Update()
    {
        // Rotar el objeto alrededor del centro en el eje Z.
        transform.RotateAround(center.position, Vector3.forward, speed * Time.deltaTime);
    }
}

