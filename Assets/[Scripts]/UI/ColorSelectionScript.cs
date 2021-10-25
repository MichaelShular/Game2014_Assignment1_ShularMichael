///ColorSelectionScript
///101273089 Michael Shular
///Last modified: 10/24/2021
///
///Summary: just changes the ui color and moves color selection buttons to color factory
///
///Revision History:
///0.1
///-float max and min

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ColorSelectionScript : MonoBehaviour
{
    private GameObject buttonOne;
    private GameObject buttonTwo;
    private GameObject buttonThree;
    private EnemyManager enemyManager;
    private EnemyTypes currentColorSelected = EnemyTypes.NONE;
    //private Vector3 towerLocation; 
    // Start is called before the first frame update
    void Start()
    {
        buttonOne = GameObject.Find("ColorButton");
        buttonTwo = GameObject.Find("ColorButton2");
        buttonThree = GameObject.Find("ColorButton3");
        enemyManager = GameObject.Find("EnemyControl").GetComponent<EnemyManager>();
        Debug.Log(enemyManager.listOfColors(1));
        buttonOne.GetComponent<SpriteRenderer>().color = new Color32(0, 0,0 ,255) + enemyManager.listOfColors(0);
        buttonTwo.GetComponent<SpriteRenderer>().color = new Color32(0, 0, 0, 255) + enemyManager.listOfColors(1);
        buttonThree.GetComponent<SpriteRenderer>().color = new Color32(0, 0, 0, 255) + enemyManager.listOfColors(2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        buttonOne.transform.position = new Vector3(transform.position.x + 1, transform.position.y + 1, 1.0f); 
        buttonTwo.transform.position = new Vector3(transform.position.x - 1, transform.position.y + 1, 1.0f);
        buttonThree.transform.position = new Vector3(transform.position.x, transform.position.y + -1, 1.0f);
        Time.timeScale = 0.2f;
    }

    public void setColor(EnemyTypes a)
    {
        currentColorSelected = a;
    }
}
