using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Public function to load a scene by its name
    public void LoadSceneByName(string sceneName)
    {
        // SceneManager.LoadScene is the function that performs the scene change
        SceneManager.LoadScene(sceneName);
    }

    // Optional: Public function to load a scene by its index in the Build Settings
    public void LoadSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    // This function will be called when the button is pressed
    public void QuitGame()
    {
        // If the application is running in a build (e.g., on PC, Mac, etc.)
        Application.Quit();

        // Optional: If you want to see if the button works in the Unity Editor
#if UNITY_EDITOR
        Debug.Log("Quit button pressed. Game closing (or stopping in Editor).");
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
