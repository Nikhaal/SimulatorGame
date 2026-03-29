using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float sensitivity = 10f;
    float yRotation = 0f;
    public GameObject cam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePos1 = Input.GetAxis("Mouse X") * sensitivity;

        yRotation -= -mousePos1;
       
        cam.transform.rotation = Quaternion.Euler(0, yRotation, 0f);
    }
}
