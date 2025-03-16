using UnityEngine;

public class ListeningLevelSystem : MonoBehaviour
{
    public Listening[] Levels;

    private void OnEnable()
    {
        Levels[0].gameObject.SetActive(true);
    }
}
