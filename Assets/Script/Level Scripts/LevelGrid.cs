using UnityEngine;
using UnityEngine.UI;

public class LevelGrid : MonoBehaviour
{
    [SerializeField] Button[] button;

    [Range(0, 10)] int unlockedLevel;
    [Range(0, 10)] int completedLevel;

    [SerializeField] Sprite lvlCompletedIcon;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("LevelIsUnlocked"))
        {
            PlayerPrefs.SetInt("LevelIsUnlocked", 1);
        }

        if (!PlayerPrefs.HasKey("CompletedLevels"))
        {
            PlayerPrefs.SetInt("CompletedLevels", 0);
        }

        unlockedLevel = PlayerPrefs.GetInt("LevelIsUnlocked");
        completedLevel = PlayerPrefs.GetInt("CompletedLevels");

        for (int i = 0; i < button.Length; i++)
        {
            button[i].interactable = false;
            button[i].gameObject.GetComponentInChildren<Transform>().GetChild(0).gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        unlockedLevel = PlayerPrefs.GetInt("LevelIsUnlocked");
        completedLevel = PlayerPrefs.GetInt("CompletedLevels");

        for (int i = 0; i < unlockedLevel; i++)
        {
            button[i].interactable = true;
            button[i].gameObject.GetComponentInChildren<Transform>().GetChild(0).gameObject.SetActive(true);
        }
        for (int i = 0; i < completedLevel; i++)
        {
            button[i].interactable = false;

            SpriteState spriteState = button[i].spriteState;
            spriteState.disabledSprite = lvlCompletedIcon;
            button[i].spriteState = spriteState;
        }
    }
}
