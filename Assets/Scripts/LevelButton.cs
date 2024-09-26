using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{
    public string levelName;

    void OnMouseDown()
    {
        transform.position += Vector3.down * 0.1f;
    }

    void OnMouseUp()
    {
        transform.position += Vector3.up * 0.1f;
        if (levelName != "")
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
