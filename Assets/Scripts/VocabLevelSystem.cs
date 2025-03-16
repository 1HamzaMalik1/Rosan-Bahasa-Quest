using UnityEngine;

public class VocabLevelSystem : MonoBehaviour
{
    public Vocab[] Levels;

    private void OnEnable()
    {
        Levels[0].gameObject.SetActive(true);
    }
}
