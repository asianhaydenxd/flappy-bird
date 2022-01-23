using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpVelocity;
    public float horizontalPrecision;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(rb.velocity.x + (Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x) / horizontalPrecision, jumpVelocity);
        }
    }
}
