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
        CreateWall();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > timePerWall && BirdMovement.isFlying)
        {
            CreateWall();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    private void CreateWall()
    {
        GameObject newWall = Instantiate(wall);
        newWall.transform.parent = gameObject.transform;
        Destroy(newWall, 15);
    }
}
