using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.IO;
public class AI : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    public GameObject hero;
    Ray r;
    RaycastHit hit;
    public LayerMask layeer;
    void Start()
    {
        
    }


    void Update()
    {
        r = Camera.main.ScreenPointToRay(transform.position);
        if (Vector3.Distance(hero.transform.position, agent.transform.position) <= 2)
        {

             if(Physics.Raycast(r,out hit,5,layeer))
            {
                Debug.Log("selected");
            }
        }
        else
        {
             
            agent.SetDestination(hero.transform.position);
        }
      
         
    }
    
}
