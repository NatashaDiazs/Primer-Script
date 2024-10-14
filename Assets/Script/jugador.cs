using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class jugador : MonoBehaviour
{
    public float speed = 5f;  //declaracion de velocidad//

    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    //movimiento vertical y horizontal//
    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal * speed, rb.velocity.y, moveVertical * speed);

        rb.velocity = movement;
    }

    //eliminar objeto// 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Colision"))
        {
            Destroy(collision.gameObject);

        }

    }

}

