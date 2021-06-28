using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampahDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "BatasBawah")
        {
            Destroy(gameObject);
        }
    }
}
