using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothness;

    private void Update()
    {
        if (target == null) return;

        var pos = target.position;
        pos.z = transform.position.z;

        transform.position = Vector3.Lerp(transform.position, pos, 1 - smoothness);
    }
}
