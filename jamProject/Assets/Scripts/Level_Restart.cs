using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class Level_Restart : MonoBehaviour
{
    public int sceneID;
    public int sceneIDPortal;
    private int CollisionCount = 0;
    private AudioSource source;
    public AudioClip ljazg;

    public Vector3 Tuda;
    public Vector3 Suda;

    public Animator ImageAnim;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(sceneID);
        }

        if (col.gameObject.tag == "Wall")
        {
            CollisionCount++;

            source.pitch = Random.Range(0.8f, 1.2f);
            source.PlayOneShot(ljazg);

            if (CollisionCount >= 5)
            {
                SceneManager.LoadScene(sceneID);
            }
        }

        if (col.gameObject.tag == "Portal")
        {
            StartCoroutine(Portal());
        }
        if (col.gameObject.tag == "Yellow")
        {
            StartCoroutine(Yellow1());
        }
        if (col.gameObject.tag == "Yellow2")
        {
            StartCoroutine(Yellow2());
        }
    }
    IEnumerator Portal()
    {
        ImageAnim.SetTrigger("FadeOut");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(sceneIDPortal);
    }
    IEnumerator Yellow1()
    {
        ImageAnim.SetTrigger("FadeOut");
        yield return new WaitForSeconds(2);
        transform.position = Tuda;
        ImageAnim.SetTrigger("FadeIn");
    }
    IEnumerator Yellow2()
    {
        ImageAnim.SetTrigger("FadeOut");
        yield return new WaitForSeconds(2);
        transform.position = Suda;
        ImageAnim.SetTrigger("FadeIn");
    }
}
