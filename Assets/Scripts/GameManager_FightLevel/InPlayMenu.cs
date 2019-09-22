using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class InPlayMenu : MonoBehaviour
{
    public GameObject inPlayMenu;

    public void ResumeButton()
    {
        Time.timeScale = 1;
        inPlayMenu.gameObject.SetActive(false);
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            inPlayMenu.gameObject.SetActive(true);
        }
    }
}
