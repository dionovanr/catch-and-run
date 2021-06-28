using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private float sumbuX;
    public float kecepatan = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        sumbuX = CrossPlatformInputManager.GetAxis("Horizontal") * kecepatan;
        rb.velocity = new Vector2(sumbuX, 0f);
    }
}
