using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disapear : MonoBehaviour
{
    public GameObject Obeject;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Obeject.SetActive(false);
    }
}
