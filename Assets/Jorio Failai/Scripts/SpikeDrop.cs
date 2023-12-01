using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDrop : MonoBehaviour
{
    public Rigidbody2D otherObjectRb; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        otherObjectRb.gravityScale = 1f;
    }
}
