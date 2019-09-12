using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nail : MonoBehaviour
{
    private bool isNailed = false;
    public float speed = 20f;
    public Rigidbody2D rb;

    void Update()
    {
        if(!isNailed)
        rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            isNailed = true;
        }
        else if (col.tag == "Nail")
        {
            FindObjectOfType <GameManager>().EndGame();
        }
    }
}
