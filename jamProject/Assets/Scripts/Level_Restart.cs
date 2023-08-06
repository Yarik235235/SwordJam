using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Restart : MonoBehaviour
{
    public int sceneID;
    private int Applescounter = 0;
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Wall")
        {
            SceneManager.LoadScene(sceneID);
            PlayerPrefs.SetInt("Count", Applescounter);
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(sceneID);
            PlayerPrefs.SetInt("Count", Applescounter);
        }
    }
}
