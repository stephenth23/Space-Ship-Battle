using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdatingLives : MonoBehaviour
{
    public Text livesText;
    public GameObject deadMenu;

    int lives = 3;

    void Start()
    {
        livesText.text = "Lives: " + lives.ToString();
    }

    public void UpdateLives()
    {
        lives -= 1;
        livesText.text = "Lives: " + lives.ToString();

        if (lives == 0)
        {
            Time.timeScale = 0;
            deadMenu.gameObject.SetActive(true);
        }
    }
}