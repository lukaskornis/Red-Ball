using UnityEngine;

public class Ball : MonoBehaviour
{
	public float jumpSpeed = 5;
	Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		var hor = Input.GetAxisRaw("Horizontal");

		rb.AddForce(new Vector2(hor, 0));

		if (Input.GetButtonDown("Jump"))
		{
			rb.velocity += Vector2.up * jumpSpeed;
		}
	}
}