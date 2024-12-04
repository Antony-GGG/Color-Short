using UnityEngine;
using UnityEngine.SceneManagement;


public class StartMenu : MonoBehaviour
{

    //[SerializeField] GameObject settingsWindow;


    public void PlayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ShowSettings()
    {
        //settingsWindow.SetActive(true);
    }

    public void ExitPanel()
    {
        //settingsWindow.SetActive(false);
    }

}
