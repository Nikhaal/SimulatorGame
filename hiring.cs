using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;

public class hiring : MonoBehaviour
{
    public GameObject worstragram;
    public GameObject hirings;
    public string[] names;
    public string[] jobs;
    int referesh_rate = 1;
    public TextMeshProUGUI name;
    public TextMeshProUGUI name2;
    public TextMeshProUGUI name3;
    public TextMeshProUGUI name4;
    public TextMeshProUGUI detailOne;
    public TextMeshProUGUI detailTwo;
    public TextMeshProUGUI detailThree;
    public TextMeshProUGUI detailFour;
    public GameObject hiring1;
    public GameObject hiring2;
    public GameObject hiring3;
    public GameObject hiring4;

    int counter = 1;

    void Start()
    {
        Debug.Log("hi");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            hiring1.SetActive(true);
            hiring2.SetActive(true);
            hiring3.SetActive(true);
            hiring4.SetActive(true);
            referesh_rate = 1;
            counter = 1;
            Debug.Log("accept");
        }
        Debug.Log(referesh_rate);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            hirings.SetActive(false);
            worstragram.SetActive(true);
        }
        
        if (referesh_rate == 1)
        {
            System.Random r = new System.Random();
            int next = r.Next(0, 5);
            int next2 = r.Next(0, 5);
            counter += 1;

            if (counter == 5)
            {
                referesh_rate = 0;
            }
            if (counter == 1)
            {
                name.text = names[next];
                detailOne.text = jobs[next2];
            }
            if (counter == 2)
            {
                name2.text = names[next];
                detailTwo.text = jobs[next2];
            }
            if (counter == 3)
            {
                name3.text = names[next];
                detailThree.text = jobs[next2];
            }
            if (counter == 4)
            {
                name4.text = names[next];
                detailFour.text = jobs[next2];
            }

        }
    }
}
 