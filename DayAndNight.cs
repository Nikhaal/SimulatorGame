using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DayAndNight : MonoBehaviour
{
    public TextMeshProUGUI counterTime;
    int countrs = 0;
    int hrs = 0;
    public Light light;
    public Camera cam;
    void Start()
    {
        StartCoroutine("Time");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Time()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            countrs += 1;
            counterTime.text = counterTime.text = hrs.ToString() + ":" + countrs.ToString();
            if(hrs==0)
            {
                cam.backgroundColor = new Color(0.6408615f, 0.643333f, 0.8264151f);
            }
            if (countrs==5)
            {
                hrs+= 1;
                countrs = 0;
                counterTime.text=hrs.ToString()+":"+countrs.ToString();
            }
            if(hrs==5)
            {
                cam.backgroundColor= new Color(0.53f, 0.81f, 0.92f);
               

            }
            if(hrs==8)
            {
                 
                cam.backgroundColor = new Color(1.0f, 0.72f, 0.37f);

            }
            if(hrs==2)
            {
                 
                cam.backgroundColor = new Color(0.04769668f, 0.2627451f, 0.1708934f);



            }
        }
    }
}
