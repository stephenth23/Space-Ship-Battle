using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdatingScore : MonoBehaviour
{
    public Text scoreText;

    public Text playMenuScoreText;

    private int score = 0;
    int highscore;

    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
        highscore = PlayerPrefs.GetInt("highscore");
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();
        playMenuScoreText.text = "Score: " + score.ToString();

        if (highscore <= score)
        {
            highscore = score;
            PlayerPrefs.SetInt("highscore", highscore);
        }
    }
}