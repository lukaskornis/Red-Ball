using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public List<string> levels;

	public int hp = 3;
	public int currentLevel;

	// singleton
	public static GameManager instance;
	void Start()
	{
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

	public void Win()
	{
		currentLevel++;
		Invoke("LoadNextLevel",1f);

	}

	void LoadNextLevel()
	{
		SceneManager.LoadScene(levels[currentLevel]);
	}

	public void Lose()
	{
		hp--;
		if (hp > 0)
		{
			// fail
			Invoke("LoadNextLevel",1f);
		}
		else
		{
			// game over
			currentLevel = 0;
			hp = 3;
			Invoke("LoadNextLevel",1f);
		}
	}
}