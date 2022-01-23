using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    public float speed = 5;
    public float height = 3;

    // Start is called before the first frame update
    void Start()
    {
        transform.position += new Vector3(0, Random.Range(-height, height), 0);
        GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);
    }
}
