using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class Navigations : MonoBehaviour
{
    public GameObject faqs;
    public GameObject userGuide;
    public Button faqsBtn;
    public Button userGuideBtn;
    public bool isFaqsOpen;
    public bool isUserGuideOpen;

    public void UserGuide()
    {
        userGuide.SetActive(!isUserGuideOpen);
        faqsBtn.interactable = isUserGuideOpen;
        isUserGuideOpen = !isUserGuideOpen;
        
    }

    public void Faqs()
    {
        faqs.SetActive(!isFaqsOpen);
        userGuideBtn.interactable = isFaqsOpen;
        isFaqsOpen = !isFaqsOpen;

    }
}
