using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public Text finalScoreText;
    public GameObject gameOverScreen;
    public AudioSource scoreSoundSource;

    public AudioSource loseSoundSource;


    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore=playerScore+scoreToAdd;
        scoreText.text = playerScore.ToString();
        if (scoreSoundSource != null)
        {
            scoreSoundSource.Play();
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        scoreText.gameObject.SetActive(false);
        finalScoreText.text = "SCORE: "+playerScore.ToString();
        gameOverScreen.SetActive(true);
        if (loseSoundSource != null)
        {
            loseSoundSource.Play();
        }
        // Freeze time
        Time.timeScale = 0f;
    }
}
