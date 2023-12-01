using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move : MonoBehaviour
{
    public float smoothness;
    public Transform target;

    void Update()
    {
        var pos = transform.position;
        pos.x = target.position.x;
        pos.y = target.position.y;


        transform.position = Vector3.Lerp(transform.position, pos, smoothness);
    }
}
