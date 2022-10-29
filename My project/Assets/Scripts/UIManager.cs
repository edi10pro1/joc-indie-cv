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

    [Header("Settings UI")]
    public GameObject cube;
    public float rotationSpeed = 10f;

    public void SceneChange(int index)
    {
        SceneManager.LoadScene(index);
    }

    #region Cube Buttons

    public void OnMouseDrag()
    {
        float XaxisRotation = Input.GetAxis("Mouse X") + rotationSpeed;
        float YaxisRotation = Input.GetAxis("Mouse Y") + rotationSpeed;

        cube.transform.Rotate(Vector3.down, XaxisRotation);
        cube.transform.Rotate(Vector3.right, YaxisRotation);
    }
    #endregion

    #region Tabs
    public void CloseAllTabs()
    {
        menuTab.SetActive(false);
        optionsTab.SetActive(false);
        creditsTab.SetActive(false);
        playTab.SetActive(false);
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

    public void Quit()
    {
        Application.Quit();
    }
    #endregion
}
