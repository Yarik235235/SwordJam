using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AppleCounter : MonoBehaviour
{
    private int Applescounter = 0;
    private int goldenCounter = 0;


    public TMP_Text apples;

    public GameObject[] appleParent;
    public GameObject Particle;

    public bool isGold;

    private void Start()
    {
        PlayerPrefs.SetInt("Count", Applescounter);
        PlayerPrefs.SetInt("CountGold", goldenCounter);
    }

    private void Update()
    {
        Applescounter = PlayerPrefs.GetInt("Count");
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Instantiate(Particle, transform.position, transform.rotation);
            if(isGold == true)
            {
                goldenCounter++;
                PlayerPrefs.SetInt("CountGold", goldenCounter);
            }
            else
            {
                Applescounter++;
                PlayerPrefs.SetInt("Count", Applescounter);
                apples.text = "Apples: " + Applescounter.ToString();
            }

            foreach(GameObject apple in appleParent)
            {
                apple.GetComponent<Rigidbody>().isKinematic = false;

                Destroy(apple, 3);
                Destroy(GetComponent<SphereCollider>());
            }
        }
    }
}
