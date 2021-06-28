using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject[] Platform;
    public float waktuSpawn;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPlatform());
    }

   
    IEnumerator SpawnPlatform()
    {
        yield return new WaitForSeconds(waktuSpawn);
        Instantiate(Platform[Random.Range(0, Platform.Length)], transform.position, Quaternion.identity);
        StartCoroutine(SpawnPlatform());
    }
}
