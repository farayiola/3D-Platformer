using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GemSliver : MonoBehaviour
{

    public GameObject scoreBox;
    public AudioSource collectSound;
     void OnTriggerEnter()
    {
        GlobalScore.currentScore += 1000;
        collectSound.Play();
        Destroy(gameObject);
    }
}
