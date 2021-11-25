using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saludene : MonoBehaviour
{
    public float salud;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bala"))
        {
            anim.SetBool("destruc", true);
            // Destroy(gameObject);
        }
        
        
    }
}

