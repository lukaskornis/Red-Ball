using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject Gate;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Ball"))
        {
            Destroy(gameObject);
            Destroy(Gate);
        }
    }
}
