using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackToHome : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Start()
    {
        scoreText.text = "Score : " + PlayerPrefs.GetInt("PlayerScore").ToString();
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    [DllImport("__Internal")]
    private static extern void GoToURLInSameTab(string url);

    public void QuitGame()
    {
        //webgl pc
        //SceneManager.LoadScene("MainMenu");
        //webgl android ios
        GoToURLInSameTab("https://platform.grandgaming.com/");
    }

    public void Restart()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(0);
    }

}
