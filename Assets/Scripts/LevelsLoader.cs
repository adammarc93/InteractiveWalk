using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevelOne()
    {
        Application.LoadLevel("Level 1");
    }

    public void LoadLevelTwo()
    {
        Application.LoadLevel("Level 2");
    }
}
