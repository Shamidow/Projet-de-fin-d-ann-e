using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{

    public AudioMixer audioMixer;
    public static bool isFullScreenm;
    public static float volumem;

    private void Start()
    {
    }

    public void  volumemanager(float volume)
    {
        audioMixer.SetFloat("volume", volume);
        volumem = volume;
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
        isFullScreenm = isFullScreen;
    }
    
}
