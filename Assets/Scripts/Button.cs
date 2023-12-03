using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public string SceneName;
    public int level;

    private void OnMouseDown()
    {
        GameManager.instance.currentLevel = level;
        SceneManager.LoadScene(SceneName);
        
    }
}
