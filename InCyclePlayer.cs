using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InCyclePlayer : MonoBehaviour
{
    public float sensitivity = 10f;
    float yRotation = 0f; 
    Rigidbody rb;
    public GameObject cam;
    public GameObject sit;
    public Camera cams;
    public Camera main;
    InCyclePlayer cy;
    Movement movement;
    void Start()
    {
        rb= GetComponent<Rigidbody>();  
        cy=GetComponent<InCyclePlayer>();
        movement = cam.GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKey(KeyCode.W) == true)
        {
            rb.velocity = new Vector3(transform.forward.x, 0, transform.forward.z) * 8;
        }
        if (Input.GetKey(KeyCode.W) == false)
        {
            rb.velocity = new Vector3(transform.forward.x, 0, transform.forward.z) * 0;
        }
        float mousePos1 = Input.GetAxis("Mouse X") * sensitivity;

        yRotation -= -mousePos1;
       
        transform.rotation = Quaternion.Euler(0, yRotation, 0f);
        if(Input.GetKeyDown(KeyCode.F))
        {
            cam.transform.position=sit.transform.position;
            cam.transform.SetParent(null);
            main.enabled = true;
            cy.enabled = false;
            movement.enabled = true;
            cams.enabled = true;
        }

    }
}
