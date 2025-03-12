using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public AudioClip impactSound;
    private AudioSource audioSource;
    public static int score = 0;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Proyectil"))
        {
            audioSource.PlayOneShot(impactSound);
            score += 10;
            Destroy(gameObject, 0.5f);
        }
    }
}
