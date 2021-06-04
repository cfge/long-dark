using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
     public GameObject bullet;
    GameObject clone;
    Rigidbody clone_rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            clone = Instantiate(bullet, transform.position,Quaternion.Euler(90f, transform.rotation.eulerAngles.y,0));
            clone_rb = clone.GetComponent<Rigidbody>();
            clone_rb.AddForce(transform.forward * 2200f);
        }
    }
      void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="enemy")
        {
            Destroy(collision.gameObject);
            
        }
    }
}
