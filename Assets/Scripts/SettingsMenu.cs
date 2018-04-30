using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour {

    public AudioMixer audioMixer;


	public void SetMusicVolume (float volume)
    {
        audioMixer.SetFloat("Music Volume", volume);
    }

    public void SetGameVolume(float volume)
    {
        audioMixer.SetFloat("Game Volume", volume);
    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;

    }
}
