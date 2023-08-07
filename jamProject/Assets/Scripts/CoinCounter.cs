using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public TMP_Text coins;
    public GameObject Particle;
    private int coinsCounter = 0;

    void Start()
    {
        PlayerPrefs.SetInt("CoinsCount", coinsCounter);
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Instantiate(Particle, transform.position, transform.rotation);
            coinsCounter++;
            PlayerPrefs.SetInt("Count", coinsCounter);
            coins.text = "Coins: " + coinsCounter.ToString();
            Destroy(gameObject);
        }
    }
}
