using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGeneration : MonoBehaviour
{
    public float timePerWall = 1;
    private float timer = 0;
    public GameObject wall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > timePerWall)
        {
            GameObject newWall = Instantiate(wall);
            Destroy(newWall, 15);
            timer = 0;

        }
        timer += Time.deltaTime;
    }
}
