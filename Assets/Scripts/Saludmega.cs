using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saludmega : MonoBehaviour
{
    public float salud;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("enemy"))
        {
           // Destroy(gameObject);
        }
        if (col.collider.CompareTag("balasen"))
        {
            //Destroy(gameObject);
        }
    }
}
