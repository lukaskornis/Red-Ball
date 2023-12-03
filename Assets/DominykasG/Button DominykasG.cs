using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonDominykasG : MonoBehaviour
{
    public string nextLevel;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(nextLevel);
    }
}