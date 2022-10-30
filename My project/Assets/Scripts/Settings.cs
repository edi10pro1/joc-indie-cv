using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class Settings : MonoBehaviour
{
    [Header("Graphics")]
    public Toggle fullscreenToggle;
    public Toggle vsyncToggle;
    public TMP_Dropdown qualityDropdown;

    [Header("Audio")]
    public AudioMixer mixer;

    public Slider masterSlider;
    public Slider musicSlider;
    public Slider sfxSlider;

    public void Start()
    {
        #region Graphics

        fullscreenToggle.isOn = PlayerPrefs.GetInt("Fullscreen") != 0;
        vsyncToggle.isOn = PlayerPrefs.GetInt("Vsync") != 0;
        qualityDropdown.value = PlayerPrefs.GetInt("QualityIndex", 0);

        if (vsyncToggle.isOn)
        {
            QualitySettings.vSyncCount = 1;
        }

        fullscreenToggle.isOn = Screen.fullScreen;

        #endregion

        #region Audio

        float vol = 0f;
        mixer.GetFloat("MasterVol", out vol);
        masterSlider.value = vol;
        mixer.GetFloat("MusicVol", out vol);
        musicSlider.value = vol;
        mixer.GetFloat("SFXVol", out vol);
        sfxSlider.value = vol;

        #endregion

        #region Keybinds

        #endregion
    }

    #region Graphics

    public void FullscreenToggle()
    {
        if (fullscreenToggle.isOn)
        {
            Screen.fullScreen = true;
        }
        else
        {
            Screen.fullScreenMode = FullScreenMode.Windowed;
        }
    }

    public void VsyncToggle()
    {
        if (vsyncToggle.isOn)
        {
            QualitySettings.vSyncCount = 1;
        }
        else
        {
            QualitySettings.vSyncCount = 0;
        }
    }

    public void SetQuality()
    {
        QualitySettings.SetQualityLevel(qualityDropdown.value);
    }

    public void ApplyGraphics()
    {
        FullscreenToggle();
        VsyncToggle();
        SetQuality();
        ApplyAudio();

        PlayerPrefs.SetInt("QualityIndex", qualityDropdown.value);
        PlayerPrefs.SetInt("Vsync", vsyncToggle.isOn ? 1 : 0);
        PlayerPrefs.SetInt("Fullscreen", fullscreenToggle.isOn ? 1 : 0);
    }

    public void ResetWithoutApplying()
    {
        fullscreenToggle.isOn = PlayerPrefs.GetInt("Fullscreen") != 0;
        vsyncToggle.isOn = PlayerPrefs.GetInt("Vsync") != 0;
        qualityDropdown.value = PlayerPrefs.GetInt("QualityIndex", 0);
    }

    #endregion

    #region Audio

    public void SetMasterVol()
    {
        mixer.SetFloat("MasterVol", masterSlider.value);

        PlayerPrefs.SetFloat("MasterVol", masterSlider.value);
    }

    public void SetMusicVol()
    {
        mixer.SetFloat("MusicVol", musicSlider.value);

        PlayerPrefs.SetFloat("MusicVol", musicSlider.value);
    }

    public void SetSFXVol()
    {
        mixer.SetFloat("SFXVol", sfxSlider.value);

        PlayerPrefs.SetFloat("SFXVol", sfxSlider.value);
    }

    public void ApplyAudio()
    {
        SetMasterVol();
        SetMusicVol();
        SetSFXVol();
        ApplyGraphics();
    }

    #endregion

    #region Keybinds

    #endregion
}
