using UnityEngine;

public class GrammarLevelSystem : MonoBehaviour
{
    public Grammar[] Levels;

    private void OnEnable()
    {
        Levels[0].gameObject.SetActive(true);
    }
}
