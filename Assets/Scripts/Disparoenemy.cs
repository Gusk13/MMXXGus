using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparoenemy : MonoBehaviour
{
    public float speed;
    public float tiempobala;
    public bool baibala;
    public float damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        

    }
    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.collider.CompareTag("player"))
        {

           

            if (!baibala)
            {
                baibala = true;
            }


        }
        if (baibala)
        {
            Destroy(gameObject, tiempobala);
            Debug.Log("puff");
        }
    }
}
