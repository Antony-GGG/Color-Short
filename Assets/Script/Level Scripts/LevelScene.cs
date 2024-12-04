using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScene : MonoBehaviour
{
    public int sceneIndex;

    public void OpenScene(int _levelIndex)
    {
        SceneManager.LoadScene(_levelIndex + 1);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(1);
    }

}
