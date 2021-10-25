///ButtonsForSceneControl 
///Shular Michael, 101273089
///Last Modified: 10/3/2021
///
///Summary: Hold all functions and code for controlling UI elements 
///for all scenes 
///
///Version History
///0.1: Added Scene mangement buttons fuction for start, main and level1
///
///0.2 Added TMPro to contol Text UI, add switch statement to control 
///UI for instructions, buttons fuctions for level 2, level3 and instruction
///
///0.3 Added tempoary button function for lose scene, added button fuction
///for pause menu

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ButtonsForSceneControl : MonoBehaviour
{
    [SerializeField] Canvas instructionsMenu;
    [SerializeField] Canvas pauseMenu;
    [SerializeField] TextMeshProUGUI info0;
    [SerializeField] TextMeshProUGUI info1;
    [SerializeField] TextMeshProUGUI info2;
    [SerializeField] TextMeshProUGUI info3;
    private float textCounter = 0;
    public void LoadStartScene()
    {
        SceneManager.LoadScene("Start");
    }
    public void LoadMainScene()
    {
        SceneManager.LoadScene("Main");
    }
    public void LoadLoseScene()
    {
        if (PlayerPrefs.GetInt("Level1") > 0)
        {
            SceneManager.LoadScene("Lose Scene");
        }
        Debug.Log(PlayerPrefs.GetInt("Level1"));
    }
    public void LoadLevel1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level1");
    }
    public void LoadLevel2()
    {
        Time.timeScale = 1;
        if (PlayerPrefs.GetInt("Level1") > 0)
        {
            SceneManager.LoadScene("Level2");
        }
    }
    public void LoadLevel3()
    {
        Time.timeScale = 1;
        if (PlayerPrefs.GetInt("Level2") > 0)
        {
            SceneManager.LoadScene("Level3");
        }

    }
    public void toggleInstructionMenu()
    {
        instructionsMenu.enabled = !instructionsMenu.enabled;
    }
    public void togglePauseMenu()
    {
        pauseMenu.enabled = !pauseMenu.enabled;
        if (pauseMenu.enabled == false)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
    }
    public void switchTextInstructions()
    {
        textCounter++;
        if(textCounter > 3)
        {
            textCounter = 0;
        }
        switch (textCounter)
        {
            case 0:
                info0.enabled = true;
                info3.enabled = false;
            break;
            case 1:
                info1.enabled = true;
                info0.enabled = false;
                break;
            case 2:
                info2.enabled = true;
                info1.enabled = false;
                break;
            case 3:
                info3.enabled = true;
                info2.enabled = false;
                break;
            default:
                break;
        }
    }
}
