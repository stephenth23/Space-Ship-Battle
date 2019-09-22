using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HomeMenu_GameManager : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetInt("highscore", 0);
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("FightLevel");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}