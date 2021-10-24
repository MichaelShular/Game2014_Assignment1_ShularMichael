///PlayerController
///101273089 Michael Shular
///Last modified: 10/23/2021
///
///Summary: Used to contol player variables like lives and building material 
///
///Revision History:
///0.1
///-get and sets numberOfLives and numberOfMaterials
///-update the UI labels in scene

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private int numberOfLives;
    [SerializeField] private int numberOfMaterials;
    private int numberOfEnemysInLevel;
    private int numberOfEnemysDefeated = 0;

    [SerializeField] private TextMeshProUGUI uILives;
    [SerializeField] private TextMeshProUGUI uICost;
    [SerializeField] private TextMeshProUGUI uIGameResult;
    [SerializeField] private Canvas gameStateCanves;


    // Start is called before the first frame update
    void Start()
    {
        numberOfEnemysInLevel = GameObject.Find("EnemyControl").GetComponent<EnemyManager>().getNumberOfEnemyInlevel();
    }

    // Update is called once per frame
    void Update()
    {
        uILives.text = numberOfLives.ToString();
            
        uICost.text = numberOfMaterials.ToString();
        
        if(numberOfEnemysInLevel == numberOfEnemysDefeated)
        {
            Time.timeScale = 0;
           gameStateCanves.enabled = true;
           uIGameResult.text = "Level Complete";
        }

        if(numberOfLives <= 0)
        {
            Time.timeScale = 0;
            gameStateCanves.enabled = true;
            uIGameResult.text = "Level Failed";
        }
    }
    public int getLives()
    {
        return numberOfLives;
    }
    public int getNumberOfMaterials()
    {
        return numberOfMaterials;
    }
    public void setLives(int a)
    {
       numberOfLives = a;
    }
    public void setNumberOfMaterials(int a)
    {
        numberOfMaterials = a;
    }

    public void incrementNumberOfEnemysDefeated()
    {
        numberOfEnemysDefeated++;
    }
}
