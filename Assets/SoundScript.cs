using UnityEngine;
using UnityEngine.UI;

public class SoundScript : MonoBehaviour
{
    private static SoundScript instance = null;
    public Text muteText;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            // This is the key function: it prevents the object from being destroyed when a new scene is loaded.
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            // If an instance already exists and it's not this one, destroy the new duplicate.
            Destroy(gameObject);
        }
    }
    // Function to mute ALL game audio
    public void ToggleAllSound()
    {
        // 1. Toggle the state first
        AudioListener.pause = !AudioListener.pause;

        // 2. Check the NEW state to update the button text accordingly.
        // If it is NOW paused, the user needs to UNMUTE it.
        if (AudioListener.pause)
        {
            muteText.text = "UNMUTE";
        }
        // If it is NOW unpaused, the user needs to MUTE it.
        else
        {
            muteText.text = "MUTE";
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
