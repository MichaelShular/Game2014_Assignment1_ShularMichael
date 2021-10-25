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
    private int maxLives;
    [SerializeField] private int numberOfMaterials;
    private int numberOfEnemysInLevel;
    private int numberOfEnemysDefeated = 0;
    public EnemyTypes choosenColor = EnemyTypes.NONE;
    //private string levelSavingResults;
    [SerializeField]private string levelName;
    public int starCount;
    [SerializeField] private TextMeshProUGUI uILives;
    [SerializeField] private TextMeshProUGUI uICost;
    [SerializeField] private TextMeshProUGUI uIGameResult;
    [SerializeField] private Canvas gameStateCanves;
    [SerializeField] private Image star;
    [SerializeField] private Image star2;
    [SerializeField] private Image star3;



    // Start is called before the first frame update
    void Start()
    {
        maxLives = numberOfLives;
        numberOfEnemysInLevel = GameObject.Find("EnemyControl").GetComponent<EnemyManager>().getNumberOfEnemyInlevel();
    }

    // Update is called once per frame
    void Update()
    {
        uILives.text = numberOfLives.ToString();
            
        uICost.text = numberOfMaterials.ToString();
        if(numberOfLives <= 0)
        {
                Time.timeScale = 0;
                gameStateCanves.enabled = true;
                PlayerPrefs.SetInt(levelName, starCount);
                uIGameResult.text = "Level Failed";
                return;
        }
        if(numberOfEnemysInLevel == numberOfEnemysDefeated)
        {
            
            Time.timeScale = 0;
            gameStateCanves.enabled = true;
            calculateStars();
            PlayerPrefs.SetInt(levelName, starCount);
            uIGameResult.text = "Level Complete";
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
    public void calculateStars()
    {
        if(maxLives == numberOfLives)
        {
            star.enabled = star2.enabled = star3.enabled = true;
            starCount = 3;
            return;
        }
        if(maxLives / 2 < numberOfLives)
        {
            star.enabled = star2.enabled = true;
            starCount = 1;
            return;
        }
        if (maxLives / 2 >= numberOfLives)
        {
            star.enabled = true;
            starCount = 2;
            return;
        }
    }



}
