using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
   public AudioSource introMusic;
    public AudioSource hardMode;
    public GameObject normalBackground;
    public GameObject demonBackground;
    void Start()
    {
        introMusic.Play();
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        introMusic.Stop();
        hardMode.Play();
        
        normalBackground.SetActive(false);
        demonBackground.SetActive(true);
    }
}
