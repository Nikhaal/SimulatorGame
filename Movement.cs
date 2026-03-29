using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    float xRotation = 0f;
    float yRotation = 0f;
    public float sensitivity = 10f;
    Rigidbody rb;
    public GameObject bicycle;
    public GameObject sit;
    Movement m;
    public InCyclePlayer mPlayer;
    public Camera cam;
    public Camera cam2;
    Ray r;
    RaycastHit hit;
    public LayerMask layeer;
    public TextMeshPro text;
    public LayerMask layer2;
    public GameObject EntireUi;
    public int intract = 1;
    public GameObject worstagram;
    public GameObject job;
    public GameObject pannel;
    int complete = -1;
    public TextMeshProUGUI t;
    public Button btn;
    public static string name;
    public GameObject Registet;
    public TextMeshProUGUI REGISETER;
    public TextMeshPro nameOfTheShop;
    public Button btns;
    public GameObject selection;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        m= GetComponent<Movement>();
        mPlayer.enabled = false;
        cam.enabled = false;
        pannel.SetActive(false);
        Registet.SetActive(!true);
        btn.onClick.AddListener(KeepName);
        btns.onClick.AddListener(reg);
    }
    void Update()
    {
      
        float mousePos= Input.GetAxis("Mouse Y") * sensitivity;
        r = Camera.main.ScreenPointToRay(transform.position);

        xRotation -= mousePos;
       // Debug.Log(xRotation);
        xRotation = Mathf.Clamp(xRotation, -37.04f, 37.04f);
        float mousePos1 = Input.GetAxis("Mouse X") * sensitivity;

        yRotation -= -mousePos1;
        //yRotation -= -mousePos1;

     

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
        if(Input.GetKey(KeyCode.W)==true)
        {
            rb.velocity = new Vector3(transform.forward.x, 0, transform.forward.z)*5;
        }
        if(Input.GetKey(KeyCode.W) == false)
        {
            rb.velocity = new Vector3(transform.forward.x, 0, transform.forward.z)*0;
        }
        if(Vector3.Distance(transform.position,bicycle.transform.position)<=3)
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                 
                m.enabled = false;
                cam.enabled = true;
                mPlayer.enabled = true;
                cam2.enabled = false;
                 
            }
        }
        if (Physics.Raycast(r, out hit, 100, layeer))
        {
            text.text = "Press E to interact";
            if(Input.GetKeyDown(KeyCode.E))

            {
                Debug.Log("ok");
            }
        }
        if(Physics.Raycast(r,out hit,200,layer2))
        {
           if(Input.GetKeyDown(KeyCode.E))
            {
                worstagram.SetActive(true);
                job.SetActive(false);
                EntireUi.SetActive(true);

                intract = 0;
            }
            

        }
        else
        {
            //text.text = "Come near";
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pannel.SetActive(false);
            Registet.SetActive(false);

        }
        if(complete==2)
        {
            nameOfTheShop.text = name;
        }





    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag=="npc")
        {
            Debug.Log("notu");
        }
        if (other.tag == "name")
        {
            if(Input.GetKeyDown(KeyCode.E)&&complete==0)
            {
                pannel.SetActive(true);
                complete = 1;
               
            }
        }
        if(other.tag=="register")
        {
            if (Input.GetKeyDown(KeyCode.E) && complete == 1)
            {
                REGISETER.text = "comany Name: "+name;
                Registet.SetActive(true);
            }

        }
        if(Input.GetKeyDown(KeyCode.E) && other.tag=="domain"&&complete==-1)
        {
            this.gameObject.SetActive(false);
            selection.SetActive(true);
            Debug.Log("ok");
            complete = 0;
        }
    }
    void KeepName()
    {
        name = t.text;
        Debug.Log(name);
        complete = 1;
    }
    void reg()
    {
        complete = 2;
        Registet.SetActive(false);

    }
    void domain()
    {
        complete = 0;
    }
}
