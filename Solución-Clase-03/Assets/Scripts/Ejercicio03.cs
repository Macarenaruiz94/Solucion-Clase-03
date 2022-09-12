using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio03 : MonoBehaviour
{
    public float speed;
    public float x;
    public float Z;
    bool esta_Saltando;
    private Rigidbody2D rb2d;

        private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Movimiento();
    }

    public void Movimiento()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            float movimiento_x = Input.GetAxis("Horizontal");
            rb2d.velocity = new Vector2(x, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            float movimiento_x = Input.GetAxis("Horizontal");
            rb2d.velocity = new Vector2(x, 0);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Z += Time.deltaTime * 10;
            transform.rotation = Quaternion.Euler(0, 0, Z);
        }

        if (Input.GetButton("Jump") && !esta_Saltando)
        {
            rb2d.AddForce(Vector2.up * speed);
            Debug.Log("Estoy saltando Wiiii");

            esta_Saltando = true;
        }
    }
}
