using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cutScene : MonoBehaviour
{
    public Text t;
    void Start()
    {
        StartCoroutine("cutscene");
    }

    
    void Update()
    {
        
    }
    IEnumerator cutscene()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            t.text = "very great company started as just an idea. Today, that idea is yours. Build your product, grow your team, and prove to the world that your startup can succeed.";
            yield return new WaitForSeconds(2);
            t.text = "Every startup begins with uncertainty, but the future belongs to those who dare to build it.";
            yield return new WaitForSeconds(2);
            t.text = "An idea is just the beginning — success comes from the decisions you make next.";
            yield return new WaitForSeconds(2);
            t.text = "why you waiting for lets get started";
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene(1);
            break;
        }
    }
}
