using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class talkScript : MonoBehaviour
{
    public TextMeshPro ui1;
    
    void Start()
    {
        StartCoroutine("game");
    }

    
    void Update()
    {
        
    }
    IEnumerator game()
    {
        while (true)
        {
            Debug.Log("hi");
;           yield return new WaitForSeconds(4);
            ui1.text = "problem:Students lose interest in traditional learning methods";
            yield return new WaitForSeconds(4);
            ui1.text = "sol:So I find Duolingo to teach interactive way";
        }
    }
}
