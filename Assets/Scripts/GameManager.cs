using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public GameObject bgMusic;
    public Button[] allButtons;
    public AudioClip buttonClickSound;
    public int levelNum;
    public GameObject[] handButtons;

    private void Awake()
    {
        if(!PlayerPrefs.HasKey("Level"))
        {
            PlayerPrefs.SetInt("Level", 0);
        }
        else
        {
            levelNum = PlayerPrefs.GetInt("Level");
        }

        handButtons[levelNum].SetActive(true);


        foreach (var button in allButtons)
        {
            button.gameObject.AddComponent<AudioSource>();
            button.onClick.AddListener(() => PlayButtonClickSound(button.gameObject.AddComponent<AudioSource>()));
        }
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainScene");
    }
    void PlayButtonClickSound(AudioSource audioSource)
    {
        audioSource.PlayOneShot(buttonClickSound);
    }

    public void IncrementLevel1()
    {
        int LevelNumber;
        LevelNumber = PlayerPrefs.GetInt("Level");
        if (LevelNumber == 0)
        {
            levelNum++;
            PlayerPrefs.SetInt("Level", levelNum);
        }
    }

    public void IncrementLevel2()
    {
        int LevelNumber;
        LevelNumber = PlayerPrefs.GetInt("Level");
        if (LevelNumber == 1)
        {
            levelNum++;
            PlayerPrefs.SetInt("Level", levelNum);
        }
    }

    public void IncrementLevel3()
    {
        int LevelNumber;
        LevelNumber = PlayerPrefs.GetInt("Level");
        if (LevelNumber == 2)
        {
            levelNum++;
            PlayerPrefs.SetInt("Level", levelNum);
        }
    }

    public void IncrementLevel4()
    {
        int LevelNumber;
        LevelNumber = PlayerPrefs.GetInt("Level");
        if (LevelNumber == 3)
        {
            levelNum = 0;
            PlayerPrefs.SetInt("Level", levelNum);
        }
    }
}
