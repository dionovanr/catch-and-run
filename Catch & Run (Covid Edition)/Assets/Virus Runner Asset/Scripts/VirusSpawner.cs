using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusSpawner : MonoBehaviour
{
    public GameObject Virus;
    public int waktu;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnVirus());
    }

    IEnumerator SpawnVirus()
    {
        yield return new WaitForSeconds(waktu);
        Instantiate(Virus, transform.position, Quaternion.identity);
        StartCoroutine(SpawnVirus());
    }
}
