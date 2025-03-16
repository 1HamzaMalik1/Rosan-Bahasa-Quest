using UnityEngine;

public class FillBanksLevelSystem : MonoBehaviour
{
    public FillInTheBlanks[] Levels;

    private void OnEnable()
    {
        Levels[0].gameObject.SetActive(true);
    }
}
