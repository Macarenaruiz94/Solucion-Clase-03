using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio01 : MonoBehaviour
{
    public float fuerza;
    public float speed;
    private Rigidbody2D rb_2d;

    private void Start()
    {
        fuerza = 100f;
        rb_2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MovimientoJugador();
    }

    private void MovimientoJugador()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Verical");

        rb_2d.velocity = new Vector2(x * speed, y);
    }
}
