using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class MainQuestion : MonoBehaviour
{
    public GameObject mainQuestion;
    public GameObject questionPanel;
    public GameObject successPanel;
    public GameObject failurePanel;
    public GameObject[] answers;
    public Button[] answerButtons; 
    public GameObject hand;
    public GameObject homeHand;

    private void OnEnable()
    {
        StartCoroutine(ShowMainQuestion());
    }

    private IEnumerator ShowMainQuestion()
    {
        yield return new WaitForSeconds(2f);
        mainQuestion.SetActive(true);
        yield return new WaitForSeconds(3f);
        StartCoroutine(ShowAnswers());
    }

    private IEnumerator ShowAnswers()
    {
        foreach (var answer in answers)
        {
            yield return new WaitForSeconds(0.5f);
            answer.SetActive(true);
        }
        yield return new WaitForSeconds(0.5f);
        hand.SetActive(true);
    }
    public void CallCourotineForSuccess()
    {
        StartCoroutine(TrueAnswerReaction());
    }

    public void CallCourotineForfailure()
    {
        StartCoroutine(WrongAnswerReaction());
    }

    public IEnumerator TrueAnswerReaction()
    {
        DisableAnswerButtons();
        yield return new WaitForSecondsRealtime(2f);
        questionPanel.transform.DOScale(0, 0.5f);
        yield return new WaitForSecondsRealtime(1f);
        questionPanel.SetActive(false);
        successPanel.SetActive(true);
    }
    public IEnumerator WrongAnswerReaction()
    {
        DisableAnswerButtons();
        yield return new WaitForSecondsRealtime(2f);
        questionPanel.transform.DOScale(0, 0.5f);
        yield return new WaitForSecondsRealtime(1f);
        questionPanel.SetActive(false);
        failurePanel.SetActive(true);
        yield return new WaitForSecondsRealtime(3f);
        homeHand.SetActive(true);
    }

    void DisableAnswerButtons()
    {
        foreach(var button in answerButtons)
        {
            button.enabled = false;
        }
        hand.SetActive(false);
    }

}
