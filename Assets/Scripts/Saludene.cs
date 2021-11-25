using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saludene : MonoBehaviour
{
    
    Animator anim;
    public GameObject rangou;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("destruc", false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("bala"))
        {

            anim.SetBool("destruc", true);
            //Destroy(gameObject);
            Debug.Log("cuchíplan");
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<Enemy>().enabled = false;
            rangou.SetActive(false);
        }
        
        
    }
}

