using UnityEngine;
using DG.Tweening;
using System.Collections;

public class Vocab : MonoBehaviour
{
    public GameObject startCharacter;
    public GameObject startScript;
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject mainQuestion;

    private void OnEnable()
    {
        StartCoroutine(StartGame());
    }

    private IEnumerator StartGame()
    {
        yield return new WaitForSeconds(1f);
        object1.SetActive(true);
        startCharacter.transform.DOMoveX(383, 0.5f);
        yield return new WaitForSeconds(1.5f);
        startScript.SetActive(true);
        yield return new WaitForSeconds(5.5f);
        object2.SetActive(true);
        yield return new WaitForSeconds(2f);
        object1.SetActive(false);
    }

    public void ClickObjectForCards()
    {
        StartCoroutine(HandleClickObjectForCards());
    }

    private IEnumerator HandleClickObjectForCards()
    {
        object2.SetActive(false);
        object3.SetActive(true);
        yield return new WaitForSeconds(2f);
        object3.SetActive(false);
        mainQuestion.SetActive(true);
    }
}
