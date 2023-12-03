using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    void OnMouseDown()
    {
        if (gameObject.tag == "Credits")
        {
            SceneManager.LoadScene("Credits");
        }
    }
}
