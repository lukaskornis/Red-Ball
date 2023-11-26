using UnityEngine;

public class Ball : MonoBehaviour
{
	public float jumpSpeed = 5;
	Rigidbody2D rb;
	public bool isGrounded;
	bool hasWon;
	public float moveForce;

	public GameObject gameManager;

	void Start()
	{
		Instantiate(gameManager);
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		var hor = Input.GetAxisRaw("Horizontal");

		rb.AddForce(new Vector2(hor, 0) * Time.deltaTime * moveForce);

		if (Input.GetButtonDown("Jump") && isGrounded)
		{
			rb.velocity += Vector2.up * jumpSpeed;
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		isGrounded = true;

		if (other.gameObject.CompareTag("Enemy"))
		{
			Die();
		}
	}

	void OnCollisionExit2D(Collision2D other)
	{
		isGrounded = false;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name != "Teleporter") return;
		if (hasWon) return;

		GameManager.instance.Win();
		hasWon = true;
	}

	void Die()
	{
		// die sounds and particles
		Destroy(gameObject);
		GameManager.instance.Lose();
	}
}