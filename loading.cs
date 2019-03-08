using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Loading());
    }

    // Update is called once per frame
    void Update()
    {
        Loading();
    }

    IEnumerator Loading()
    {
        yield return new WaitForSeconds(10);
        Application.LoadLevel("menuutama");
    }
}
