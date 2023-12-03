using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp : MonoBehaviour
{
    public GameObject Player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player.transform.position = new Vector2(0, -100);
    }


}
