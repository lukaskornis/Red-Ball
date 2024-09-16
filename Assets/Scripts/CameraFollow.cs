using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public float smoothness;
	public Transform target;

	void Update()
	{
		if (target == null) return;

		var pos = target.position;
		pos.z = transform.position.z;

		transform.position = Vector3.Lerp(transform.position,pos,1 - smoothness);
	}
}