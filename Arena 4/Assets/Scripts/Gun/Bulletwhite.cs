using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletwhite : MonoBehaviour
{

    public Mover2 mover2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("Hit");
        }
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Shield2"))
        {
            Destroy(gameObject);
            mover2.count++;

            Debug.Log("Parry");
            
        }
    }
}