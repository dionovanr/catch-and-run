using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Character : MonoBehaviour
{
    private Rigidbody2D rb;
    public float kekuatanLompat = 10f;

    // Start is called before the first frame update

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * kekuatanLompat;
            //suaraLompat.Play();
            SoudManager.PlaySound("jump");
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            rb.AddForce(new Vector2(0f, kekuatanLompat), ForceMode2D.Force);
            //suaraLompat.Play();
        }
    }


}
