using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDeath : MonoBehaviour
{
    public GameObject youFell;
    public GameObject LevelAudio;
    public GameObject fadeOut;
    private void OnTriggerEnter()
     
    {
        StartCoroutine(YouFellOff());
        
    }
    IEnumerator YouFellOff()
    {
youFell.SetActive(true);
        LevelAudio.SetActive(false);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        GlobalScore.currentScore = 0;
        SceneManager.LoadScene(RedirectToLevel.redirectToLevel);
    }
}
