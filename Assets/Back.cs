using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    void OnMouseDown()
    {
        if (gameObject.tag == "Back")
        {
            SceneManager.LoadScene("Menu1");
        }
    }
}
