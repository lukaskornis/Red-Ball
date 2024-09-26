using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingEnemy : MonoBehaviour
{
    public float destructionDelay;

    void Start()
    {       
        destructionDelay += Random.Range(-.5f, .5f);
    }

    void Update()
    {
        Invoke("Destroy", destructionDelay);
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}