using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AppleCounter : MonoBehaviour
{
    public int Applescounter = 0;
    public TMP_Text apples;

    public GameObject[] appleParent;

    private void Update()
    {
        Applescounter = PlayerPrefs.GetInt("Count");
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Applescounter++;
            PlayerPrefs.SetInt("Count", Applescounter);
            apples.text = "Apples: " + Applescounter.ToString();
            foreach(GameObject apple in appleParent)
            {
                apple.GetComponent<Rigidbody>().isKinematic = false;

                Destroy(apple, 3);
                Destroy(GetComponent<SphereCollider>());
            }
        }
    }
}
