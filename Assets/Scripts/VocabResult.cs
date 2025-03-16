using System.Collections;
using UnityEngine;

public class VocabResult : MonoBehaviour
{
    public GameObject endCharacter;
    public GameObject endScript;
    public GameObject nextButton;
    public bool isWin;
    private void OnEnable()
    {
        StartCoroutine(TrueAnswer());
        
    }

    private IEnumerator TrueAnswer()
    {
        endCharacter.SetActive(true);
        yield return new WaitForSecondsRealtime(0.5f);
        endScript.SetActive(true);
        yield return new WaitForSecondsRealtime(2f);
        if(isWin)
            nextButton.SetActive(true);
    }

   
    

}
