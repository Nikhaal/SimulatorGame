using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class domainSelection : MonoBehaviour
{
    Vector3 startPoint = new Vector3(10.1199999f, 5.92999983f, 35.6199989f);
     Vector3 endPoint = new Vector3(9.94999981f, 14.3999996f, 35.6199989f);
    public float duration = 2f; 
    private float elapsedTime = 0f;
    public TextMeshPro pro1;
    public TextMeshPro pro2;
   static string name = "";
    int counter = 0;
    public GameObject normal;
    
void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            pro1.color = Color.red;
            pro2.color = Color.white;
             transform.position = startPoint;
            counter = 0;
        }
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            pro1.color = Color.white;
            pro2.color = Color.red;
            transform .position = endPoint;
            counter = 1;
        }
        if(counter==0)
        {
            if(Input.GetKeyDown(KeyCode.Q))
            {
                name = "GD";
                Debug.Log(name);
                this.gameObject.SetActive(false);
                normal.SetActive(true);
            }
        }
        if (counter == 1)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                name = "AI";
                Debug.Log(name);
                this.gameObject.SetActive(false);
                normal.SetActive(true);
            }
        }
       
        
    }

    void Start()
    {
        transform.position = startPoint;
    }

    
   
}
