using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadDelay = 1.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    void OnCollisionEnter2D(Collision2D other) 
    {
        crashEffect.Play();
        GetComponent<AudioSource>().PlayOneShot(crashSFX);
        Invoke("ReloadScene", reloadDelay);
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
