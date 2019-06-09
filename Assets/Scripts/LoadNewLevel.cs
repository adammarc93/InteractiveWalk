using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNewLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider colider)
    {
        GetComponent<AudioSource>().Play();
        StartCoroutine("GoToNewLevel");
    }

    IEnumerator GoToNewLevel()
    {
        yield return new WaitForSeconds(2f);
        Application.LoadLevel("Level 2");
    }
}
