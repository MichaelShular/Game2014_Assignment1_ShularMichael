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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
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
        SceneManager.LoadScene("Lose Scene");
    }
    public void LoadLevel1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level1");
    }
    public void LoadLevel2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level2");
    }
    public void LoadLevel3()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level3");
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
