using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public GameObject audioContainer;
    private bool isActive = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchMusic()
    {
        if (!isActive)
        {
            audioContainer.SetActive(true);
            isActive = true;
        }
        else
        {
            audioContainer.SetActive(false);
            isActive = false;
        }
    }
}