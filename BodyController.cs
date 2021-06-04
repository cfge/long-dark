using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BodyController : MonoBehaviour
{
    
    float vertical;
    float horizontal;
    public GameObject player;
    float yRotate;
    Transform tr;
    Rigidbody rg;
    void Start()
    {
        tr = GetComponent<Transform>();
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        rg.AddForce(tr.forward * vertical * 5f);
        rg.AddForce(tr.right * horizontal * 10f);
        transform.rotation = Quaternion.Euler(0, yRotate, 0);
        

    }

    public void SomeMethod(float val)
    {
        yRotate = val;
    }
     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="enemy")
        {
            SceneManager.LoadScene("lose");
            
        }
    }
}
