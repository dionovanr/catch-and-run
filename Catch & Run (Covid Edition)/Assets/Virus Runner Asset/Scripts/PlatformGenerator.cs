using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public float kecepatan;

    void Update()
    {
        transform.Translate(Vector2.left * kecepatan * Time.deltaTime);
    }
}
