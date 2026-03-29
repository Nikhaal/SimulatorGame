using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIHAndler : MonoBehaviour
{
    public GameObject EntireUi;
    int inputSelect = 1;
    public Movement mvnt;
    public GameObject worstagram;
    public GameObject job;
   
    void Start()
    {
        EntireUi.SetActive(!true);
        worstagram.SetActive(!false);
        job.SetActive(false);
    }

     
    void Update()
    {
        
        if (mvnt.intract == 0)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                EntireUi.SetActive(false);
                mvnt.intract = 1;
                
            }
            
             if (Input.GetKeyDown(KeyCode.RightArrow))
             {
                 inputSelect += 1;
                 Debug.Log(inputSelect);
                 if(inputSelect==4)
                 {
                     inputSelect = 1;
                 }

             }
             
            if (inputSelect == 1)
            {
                Debug.Log("ok");
            }
            if(inputSelect==2)
            {
                Debug.Log("hi");
            }
            if(inputSelect==1&&Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                worstagram.SetActive(false);
                job.SetActive(true);

            }
        }
        
        
    }
}
