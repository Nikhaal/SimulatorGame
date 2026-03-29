using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;
public class ChatBot : MonoBehaviour
{
    public GameObject fab;
    int textShoq = 0;
    public Text t;
    List<string> list = new List<string>();
    string[] text = new string[1] ;
    public TextMeshProUGUI answer;
    void Start()
    {
        fab.SetActive(false);
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftControl)&&Input.GetKeyDown(KeyCode.C))
        {
            if(textShoq%2==0)
            {
                fab.SetActive(true);
                textShoq += 1;
            }
            else
            {
                fab.SetActive(!true);
                textShoq += 1;
            }
        }
        if(Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Debug.Log("wirte");
            list.Add(t.text);
            File.WriteAllLines("D:\\AiShare\\question.txt", list);
             
            
        }
        if (File.Exists("D:\\AiShare\\answer.txt"))
        {
            text=File.ReadAllLines("D:\\AiShare\\answer.txt");
            Debug.Log(text);
            answer.text = text[0];
            File.Delete("D:\\AiShare\\answer.txt");
        }
    }
}
