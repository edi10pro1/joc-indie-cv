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
    public int rotatiY = 0;
    public int rotatiX = 0;
    public int rotatiZ = 0;

    public void SceneChange(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void RotateCubeY(int rotationY)
    {
        rotatiY += rotationY;
        cube.transform.rotation = Quaternion.Euler(rotatiX, rotatiY, rotatiZ);
    }

    public void RotateCubeX(int rotationX)
    {
        if (cube.transform.rotation.y == 90 || cube.transform.rotation.y == -90)
        {
            rotatiZ += rotationX;
        }
        else
        {
            rotatiX += rotationX;
        }
            
        cube.transform.rotation = Quaternion.Euler(rotatiX, rotatiX,rotatiX);
    }

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
}
