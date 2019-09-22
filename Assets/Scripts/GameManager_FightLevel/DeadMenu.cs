using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeadMenu : MonoBehaviour
{
    public GameObject deadMenu;
    public Text deadMenuHighscoreText;

    void Update()
    {
        deadMenuHighscoreText.text = "Highscore: " + PlayerPrefs.GetInt("highscore");
    }

    public void ReplayButton()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
        deadMenu.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}