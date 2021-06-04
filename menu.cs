using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    string GetName;
    // Start is called before the first frame update
    void Start()
    {
        GetName = PlayerPrefs.GetString("lolkek");
        print(GetName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene("De");
    }
    public void Continue(){
        SceneManager.LoadScene("GetName");
    }
}
