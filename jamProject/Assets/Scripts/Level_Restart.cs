using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Restart : MonoBehaviour
{
    public int sceneID;
    private void OnCollisionEnter(Collision collision)
    {
        if(gameObject.tag == "Line")
        {
            
            SceneManager.LoadScene(sceneID);
        }
    }
}
