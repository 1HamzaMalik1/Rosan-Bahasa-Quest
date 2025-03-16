using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class FillInTheBlanks : MonoBehaviour
{
    public GameObject startCharacter;
    public GameObject startScript;
    public GameObject startScript2;
    public GameObject failureScript;
    public GameObject object1;
    public GameObject object2;
    public GameObject successPanel;
    public GameObject failurePanel;
    public GameObject nextButton;
    public GameObject question;
    public Button[] allButtons;
    public GameObject homeHand;

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
        yield return new WaitForSeconds(6f);
        object2.SetActive(true);
        startScript2.SetActive(true);
        yield return new WaitForSeconds(2f);
        object1.SetActive(false);
    }

    public void ClickObjectSuccess()
    {
        StartCoroutine(HandleClickObjectSuccess());
    }

    public void ClickObjectFailure()
    {
        StartCoroutine(HandleClickObjectFailure());
    }
    private IEnumerator HandleClickObjectSuccess()
    {
        foreach(var button in allButtons)
        {
            button.interactable = false;
        }
        yield return new WaitForSeconds(1.5f);
        question.transform.DOScale(0, 0.5f);
        yield return new WaitForSeconds(2f);
        question.SetActive(false);
        successPanel.SetActive(true);
        yield return new WaitForSeconds(1f);
        nextButton.SetActive(true);
    }
    private IEnumerator HandleClickObjectFailure()
    {

        foreach (var button in allButtons)
        {
            button.interactable = false;
        }
        yield return new WaitForSeconds(1.5f);
        question.transform.DOScale(0, 0.5f);
        yield return new WaitForSeconds(2f);
        question.SetActive(false);
        failurePanel.SetActive(true);
        yield return new WaitForSeconds(1f);
        failureScript.SetActive(true);
        yield return new WaitForSeconds(3f);
        homeHand.SetActive(true);
    }
}
