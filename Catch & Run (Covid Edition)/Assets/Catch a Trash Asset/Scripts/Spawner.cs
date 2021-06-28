using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] sampah;
    public float waktu;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnSampah());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnSampah ()
    {
        yield return new WaitForSeconds(waktu);
        Instantiate(sampah[Random.Range(0, sampah.Length)], transform.position, transform.rotation);
        StartCoroutine(SpawnSampah());
    }
}
