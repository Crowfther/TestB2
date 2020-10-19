using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPlayer : MonoBehaviour
{
    [SerializeField]

    float fuerza = 3;
    float x, y; //Para leer el gamepad.
    
    Rigidbody2D rb; // Para acceder al componente RigidBody


    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // rb apunta al componente Rigidbody2D del jugador.
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");    //Leer movimiento horizontal.
        y = Input.GetAxis("Vertical");      //Leer movimiento vertical.
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(x*fuerza, y*fuerza));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if (collision.tag == "Pickup") Destroy(collision.gameObject);
        if (collision.CompareTag("Pickup"))
        {
            Destroy(collision.gameObject); // Optimización de la orden anterior.
            ScrControlGame.puntos += 5;
            print ("Puntuación: " + ScrControlGame.puntos);
        }
    }
}
