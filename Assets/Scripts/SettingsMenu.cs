using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void SetVolume(float volume)
    {
        var m_volume = Mathf.Log10(volume) * 20;
        if (volume == 0.0f)
        {
            m_volume = -80.0f;
        }
        audioMixer.SetFloat("Volume", m_volume);
    }
}
