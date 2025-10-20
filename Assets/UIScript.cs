using UnityEngine;

public class UIScript : MonoBehaviour
{
    public GameObject pauseScreen;
    public GameObject pauseButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowPauseScreen()
    {
        Time.timeScale = 0f;
        pauseScreen.SetActive(true);
        pauseButton.SetActive(false);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseScreen.SetActive(false);
        pauseButton.SetActive(true);
    }
}
