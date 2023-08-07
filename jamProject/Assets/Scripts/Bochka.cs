using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Bochka : MonoBehaviour
{
    public GameObject[] bochkaKuski;
    public GameObject Particle;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Instantiate(Particle, transform.position, transform.rotation);
            Destroy(GetComponent<BoxCollider>());
            foreach (GameObject kusok in bochkaKuski)
            {
                kusok.GetComponent<Rigidbody>().isKinematic = false;

                Destroy(kusok, 3);
                Destroy(GetComponent<SphereCollider>());
            }
        }
    }
}
