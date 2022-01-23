using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePoint : MonoBehaviour
{
    public GameObject scoreTracker;

    void OnTriggerEnter2D(Collider2D collider)
    {
        scoreTracker.GetComponent<ScoreUpdate>().score++;
    }
}
