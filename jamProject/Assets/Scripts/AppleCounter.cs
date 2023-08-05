using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AppleCounter : MonoBehaviour
{
    public int Applescounter = 0;
    public TMP_Text apples;

    public GameObject[] appleParent;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Apple")
        {
            Debug.Log("Apple");
            //apples.text = Applescounter.ToString();
            foreach(GameObject apple in appleParent)
            {
                apple.GetComponent<Rigidbody>().isKinematic = false;
                Destroy(apple, 3);
            }
        }
    }
}
