using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject player;                                                                     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log( Vector2.Distance(transform.position, player.transform.position) );
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, player.transform.position);
    }
}
