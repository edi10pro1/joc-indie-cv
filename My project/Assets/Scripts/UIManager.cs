using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    [Header("Tabs")]
    public GameObject menuTab;
    public GameObject optionsTab;
    public GameObject creditsTab;
    public GameObject playTab;
    public GameObject customizeTab;

    [Header("Settings Scene")]
    public int index;
    public TextMeshProUGUI levelText;
    public GameObject informationLevel;
    public GameObject cube;

    [Header("Tabs Options")]
    public GameObject graphicsTab;
    public GameObject audioTab;
    public GameObject keybindsTab;

    public void LevelChose(int level)
    {
        levelText.text = level.ToString();
        index = int.Parse(levelText.text);
        informationLevel.SetActive(true);
    }

    public void SceneChange()
    {
        SceneManager.LoadScene(index);
    }

    #region Tabs
    public void CloseAllTabs()
    {
        cube.transform.rotation = Quaternion.Euler(0,0,0);
        menuTab.SetActive(false);
        optionsTab.SetActive(false);
        creditsTab.SetActive(false);
        playTab.SetActive(false);
        informationLevel.SetActive(false);
        customizeTab.SetActive(true);
    }

    public void GraphicsTab()
    {
        graphicsTab.SetActive(true);
        audioTab.SetActive(false);
        keybindsTab.SetActive(false);
    }

    public void AudioTab()
    {
        graphicsTab.SetActive(false);
        audioTab.SetActive(true);
        keybindsTab.SetActive(false);
    }

    public void KeybindTab()
    {
        graphicsTab.SetActive(false);
        audioTab.SetActive(false);
        keybindsTab.SetActive(true);
    }

    public void MenuTab()
    {
        CloseAllTabs();
        menuTab.SetActive(true);
    }

    public void PlayTab()
    {
        CloseAllTabs();
        playTab.SetActive(true);
    }

    public void OptionsTab()
    {
        CloseAllTabs();
        optionsTab.SetActive(true);
    }

    public void CreditsTab()
    {
        CloseAllTabs();
        creditsTab.SetActive(true);
    }

    public void CustomizeTab()
    {
        CloseAllTabs();
        customizeTab.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
    #endregion
}
