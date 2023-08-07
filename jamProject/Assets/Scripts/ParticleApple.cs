using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleApple : MonoBehaviour
{
    private AudioSource source;
    public AudioClip[] sound;

    void Start()
    {
        source = GetComponent<AudioSource>();
        source.pitch = Random.Range(0.8f, 1.2f);
        source.PlayOneShot(sound[Random.Range(0, sound.Length)]);
    }
}
