using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bullet : MonoBehaviour
{
     static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
      void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="enemy")
        {
            score = score + 1;
            Destroy(collision.gameObject);
            print(score);
            if(score==3){
                SceneManager.LoadScene("win");
            }
        }
    }
}
