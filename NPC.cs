using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NPC : MonoBehaviour
{
     NavMeshAgent agent;
    public GameObject target;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        agent.SetDestination(target.transform.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag== "Main Camera")
        {
            Debug.Log("ok");
        }
    }
}
