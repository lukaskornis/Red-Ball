using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Btn : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (gameObject.tag == "pr30")
        {
            SceneManager.LoadScene("AretasR");
        }
        if (gameObject.tag == "pr31")
        {
            SceneManager.LoadScene("DeimisM_Cave");
        }
        if (gameObject.tag == "pr19")
        {
            SceneManager.LoadScene("JustasB Sky Islands");
        }
        if (gameObject.tag == "pr26")
        {
            SceneManager.LoadScene("AugustinasSMountains");
        }
        if (gameObject.tag == "pr35")
        {
            SceneManager.LoadScene("Ignas È. Cave");
        }
        if (gameObject.tag == "pr24")
        {
            SceneManager.LoadScene("VincentasS-plains");
        }
        if (gameObject.tag == "pr33")
        {
            SceneManager.LoadScene("BenediktasD");
        }
        if (gameObject.tag == "pr36")
        {
            SceneManager.LoadScene("Kasparas B. Level");
        }
        if (gameObject.tag == "pr39")
        {
            SceneManager.LoadScene("UgniusSCave");
        }
        if (gameObject.tag == "pr40")
        {
            SceneManager.LoadScene("JorisS Sky Islands");
        }
    }
}
