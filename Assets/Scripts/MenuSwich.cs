using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSwich : MonoBehaviour
{
    public GameObject panelMenu;
    private bool isActive = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TurnOnMenu()
    {
        if (!isActive)
        {
            panelMenu.SetActive(true);
            isActive = true;
        }
        else
        {
            panelMenu.SetActive(false);
            isActive = false;
        }
    }
}
