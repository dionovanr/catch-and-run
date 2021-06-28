using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusMove : MonoBehaviour
{
    public float kecepatan;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * kecepatan * Time.deltaTime);
    }
}
