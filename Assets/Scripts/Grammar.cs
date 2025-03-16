using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.XR;

public class Grammar : MonoBehaviour
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
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;
    public GameObject greenImage;
    public GameObject redImage;
    public GameObject hand;
    public GameObject homeHand;
    int count;
    string finalText;
    

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

    public void ClickObjectSuccess(string Text)
    {
        finalText += Text;
        if(count == 0)
        {
            text1.gameObject.SetActive(true);
            text1.text = Text;
            count++;
        }
        else if(count == 1)
        {
            text2.gameObject.SetActive(true);
            text2.text = Text;
            count++;
        }
        else
        {
            hand.SetActive(false);
            text3.gameObject.SetActive(true);
            text3.text = Text;
            StartCoroutine(HandleClickObjectSuccessOrFailure(finalText));
        }
    }

    private IEnumerator HandleClickObjectSuccessOrFailure(string text)
    {
        if (text == "sayamakannasi")
        {
            greenImage.SetActive(true);
            yield return new WaitForSeconds(1.5f);
            button1.transform.DOScale(0, 0.5f);
            button2.transform.DOScale(0, 0.5f);
            button3.transform.DOScale(0, 0.5f);
            yield return new WaitForSeconds(2f);
            button1.SetActive(false);
            button2.SetActive(false);
            button3.SetActive(false);
            successPanel.SetActive(true);
            yield return new WaitForSeconds(1f);
            nextButton.SetActive(true);
        }
        else
        {
            redImage.SetActive(true);
            yield return new WaitForSeconds(1.5f);
            button1.transform.DOScale(0, 0.5f);
            button2.transform.DOScale(0, 0.5f);
            button3.transform.DOScale(0, 0.5f);
            yield return new WaitForSeconds(2f);
            button1.SetActive(false);
            button2.SetActive(false);
            button3.SetActive(false);
            failurePanel.SetActive(true);
            yield return new WaitForSeconds(1f);
            failureScript.SetActive(true);
            yield return new WaitForSeconds(1f);
            homeHand.SetActive(true);
        }
        
    }
    
}
