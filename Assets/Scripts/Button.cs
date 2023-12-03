using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public string levelname = "";

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnMouseUp()
    {
        if (levelname != "")
        {
            SceneManager.LoadScene(levelname);
        }
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
