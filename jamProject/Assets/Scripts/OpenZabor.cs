using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenZabor : MonoBehaviour
{
    public float diseredDuration = 3f;
    private float elapsedTime;
    public Vector3 KudaEdim = new Vector3(7.695895f, -5.85f, -0.45f);
    private Vector3 OtKuda;
    private int AppleCount;
    private int GoldCount;
    public int NeedToOpen;
    public bool isGolden;

    void Start()
    {
        OtKuda = transform.position;
    }

    void Update()
    {
        AppleCount = PlayerPrefs.GetInt("Count");
        GoldCount = PlayerPrefs.GetInt("CountGold");

        if(isGolden == true)
        {
            if (GoldCount >= NeedToOpen)
            {
                elapsedTime += Time.deltaTime;
                float percentageComplete = elapsedTime / diseredDuration;
                transform.position = Vector3.Lerp(OtKuda, KudaEdim, percentageComplete);
            }
        }

        if (isGolden == false)
        {
            if (AppleCount >= NeedToOpen)
            {
                elapsedTime += Time.deltaTime;
                float percentageComplete = elapsedTime / diseredDuration;
                transform.position = Vector3.Lerp(OtKuda, KudaEdim, percentageComplete);
            }
        }
    }
}
