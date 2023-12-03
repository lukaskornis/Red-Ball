using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public string level = "Showcase";
    private void OnMouseDown()
    {
        SceneManager.LoadScene(level);
    }
}
