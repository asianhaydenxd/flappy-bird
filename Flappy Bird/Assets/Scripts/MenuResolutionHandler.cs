using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuResolutionHandler : MonoBehaviour
{
    public GameObject horizontalMenu;
    public GameObject verticalMenu;

    // Start is called before the first frame update
    void Start()
    {
        if (Screen.width < Screen.height)
        {
            horizontalMenu.SetActive(false);
            verticalMenu.SetActive(true);
        }
        else
        {
            horizontalMenu.SetActive(true);
            verticalMenu.SetActive(false);
        }
    }
}
