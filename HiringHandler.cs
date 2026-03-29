using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
public class HiringHandler : MonoBehaviour
{
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;
    public TextMeshProUGUI text4;
    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    public GameObject card4;
    public GameObject npc;
    int select = 1;
    public TextMeshProUGUI money;
    int total_amount = 1000;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            select += 1;
            if(select==5)
            {
                select = 1;
            }
        }
        if(select==1)
        {
            if(Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                if(int.Parse(money.text)>500)
                {
                    total_amount -= 500;
                    money.text=total_amount.ToString();
                    Instantiate(npc, new Vector3(-5.88999987f, -1.86000001f, 3.22000003f), Quaternion.Euler(new Vector3(0, 249.700012f, 0)));
                    card1.SetActive(false);
                }
                
            }
           
            text1.color = Color.red;
            text2.color=Color.white;
            text3.color = Color.white;
            text4.color = Color.white;
        }
        if (select == 2)
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                if (int.Parse(money.text) > 500)
                {
                    total_amount -= 500;
                    money.text = total_amount.ToString();
                    Instantiate(npc, new Vector3(-5.88999987f, -1.86000001f, 3.22000003f), Quaternion.Euler(new Vector3(0, 249.700012f, 0)));
                    card2.SetActive(false);
                }
                
            }
            text2.color = Color.red;
            text3.color = Color.white;
            text4.color = Color.white;
            text1.color = Color.white;
        }
        if (select == 3)
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                if (int.Parse(money.text) > 500)
                {
                    total_amount -= 500;
                    money.text = total_amount.ToString();
                    Instantiate(npc, new Vector3(-5.88999987f, -1.86000001f, 3.22000003f), Quaternion.Euler(new Vector3(0, 249.700012f, 0)));
                    card3.SetActive(false);
                }
                
            }
            text3.color = Color.red;
            text4.color = Color.white;
            text1.color = Color.white;
            text2.color = Color.white;
        }
        if (select == 4)
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                if (int.Parse(money.text) > 500)
                {
                    total_amount -= 500;
                    money.text = total_amount.ToString();
                    Instantiate(npc, new Vector3(-5.88999987f, -1.86000001f, 3.22000003f), Quaternion.Euler(new Vector3(0, 249.700012f, 0)));
                    card4.SetActive(false);
                }
            }
            
            text4.color = Color.red;
            text3.color = Color.white;
            text2.color = Color.white;
            text1.color = Color.white;
        }
    }
}
