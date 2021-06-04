using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class head : MonoBehaviour
{
    
    float xRotate;
    float yRotate;
    float sens = 3f;
    private MeshRenderer inv;
    private BoxCollider niv;
    Transform tr_player;
    public GameObject hand;
    public GameObject interact;
    public GameObject hunter;
    public GameObject weapon;
    RaycastHit hit_object;

    void Start()
    {
        tr_player = GetComponent<Transform>();     
    }

    void Update()
    {
        inv = hand.GetComponent<MeshRenderer>();
        niv = weapon.GetComponent<BoxCollider>();
        interact.SetActive(false);
        xRotate = xRotate - Input.GetAxis("Mouse Y") * sens;
        yRotate = yRotate + Input.GetAxis("Mouse X") * sens;
        xRotate = Mathf.Clamp(xRotate, -90, 90);
        transform.rotation = Quaternion.Euler(xRotate, yRotate, 0);
        FindObjectOfType<BodyController>().SomeMethod(yRotate);
        Debug.DrawRay(transform.position, transform.forward*3f, Color.red);
        if(Input.GetKeyDown("e"))
                    {
                         weapon.transform.SetParent(null); 
                         inv.enabled = true;
                    }
          if(Physics.Raycast(transform.position, transform.forward,out hit_object,3f))
        {
                if(hit_object.collider.gameObject.tag=="spear"){
                    interact.SetActive(true);
                    if(Input.GetKeyDown("e"))
                    {
                        weapon.transform.position = hand.transform.position;
                        weapon.transform.rotation = hand.transform.rotation;
                        weapon.transform.SetParent(hand.transform);
                        inv.enabled = false;
                        niv.enabled = false;
                    }
                    
            }
        }
    }
}
