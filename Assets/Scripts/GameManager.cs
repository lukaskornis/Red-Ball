using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public List<string> levels;

	public int hp = 3;
	public int currentLevel;

	public static GameManager instance;

	public Transform transition;
	Vector3 targetScale;

	public AudioClip winSound;
	public AudioClip loseSound;
	public AudioClip gameOverSound;
	AudioSource source;

	void Start()
	{
		Application.targetFrameRate = 60;

		source = GetComponent<AudioSource>();
		if (instance == null)
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}

	void Update()
	{
		transition.localScale = Vector3.MoveTowards(transition.localScale,targetScale, 50 * Time.deltaTime);
	}

	public void Win()
	{
		currentLevel++;
		Invoke("LoadNextLevel",1f);
		targetScale = Vector3.one * 25;
		source.PlayOneShot(winSound);
	}

	void LoadNextLevel()
	{
		SceneManager.LoadScene(levels[currentLevel]);
		targetScale = Vector3.zero;
	}

	public void Lose()
	{
		hp--;
		if (hp > 0)
		{
			// fail
			Invoke("LoadNextLevel",1f);
			source.PlayOneShot(loseSound);
		}
		else
		{
			// game over
			currentLevel = 0;
			hp = 3;
			Invoke("LoadNextLevel",1f);
			source.PlayOneShot(gameOverSound);
		}

		targetScale = Vector3.one * 25;
	}
}