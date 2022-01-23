using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePoint : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        ScoreUpdate.score++;
        transform.gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }
}
