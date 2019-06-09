using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoCell : MonoBehaviour
{
    public GameObject spotLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        spotLight.SetActive(true);
    }
}