using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class talk2 : MonoBehaviour
{
    public TextMeshPro tmp;
    void Start()
    {
        StartCoroutine("talk");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator talk()
    {
        while (true)
        {
            yield return new WaitForSeconds(4);
            tmp.text = "problem:Lack of social interaction, especially for introverts.";
            yield return new WaitForSeconds(4);
            tmp.text = "sol:AI acts as a virtual friend so found replica";
            
        }
    }
}
