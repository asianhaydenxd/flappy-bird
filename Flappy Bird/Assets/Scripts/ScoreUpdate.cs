using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdate : MonoBehaviour
{
    public GameObject txt;
    public int score;

    // Update is called once per frame
    void Update()
    {
        txt.GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
}
