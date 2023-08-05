using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AppleCounter : MonoBehaviour
{
    public int Applescounter = 0;
    public TMP_Text apples;
    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag == "Apple")
        {
            Debug.Log("Apple");
            apples.text = Applescounter.ToString();
            Destroy(gameObject);
        }
    }
}
