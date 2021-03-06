using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject wallParent;
    public GameObject gameManager;
    public static bool isFlying;
    public float jumpVelocity;
    public float horizontalPrecision;
    public float restartDelay = 2;

    // Start is called before the first frame update
    void Start()
    {
        isFlying = true;
        rb = GetComponent<Rigidbody2D>();
        rb.angularVelocity = -180;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFlying && (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space")))
        {
            rb.velocity = new Vector2(0, jumpVelocity);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (isFlying)
        {
            isFlying = false;
            foreach (Transform child in wallParent.transform)
            {
                child.GetComponent<Rigidbody2D>().velocity *= 0;
            }
            
            gameManager.GetComponent<GameOverBehaviour>().GameOver();
        }
    }
}
