///EnemyFactory
///101273089 Michael Shular
///Last modified: 10/23/2021
///
///Summary: Class is used to create the different types of of enemy using the 
///factory pattern 
///
///Revision History:
///0.1
///-test game objects that are instantiated base off a switch case
///

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class EnemyFactory : MonoBehaviour
{
    public GameObject slime;

    public GameObject createEnemy(EnemyTypes enemy)
    {
        GameObject tempEnemy = null;
        switch (enemy)
        {
            case EnemyTypes.BLUE:
                tempEnemy = Instantiate(slime);
                tempEnemy.GetComponent<SpriteRenderer>().color = Color.blue;
                tempEnemy.GetComponent<DefualtEnemyController>().setColor(EnemyTypes.BLUE);
                break;
            case EnemyTypes.GREEN:
                tempEnemy = Instantiate(slime);
                tempEnemy.GetComponent<SpriteRenderer>().color = Color.green;
                tempEnemy.GetComponent<DefualtEnemyController>().setColor(EnemyTypes.GREEN);


                break;
            case EnemyTypes.RED:
                tempEnemy = Instantiate(slime);
                tempEnemy.GetComponent<SpriteRenderer>().color = Color.red;
                //tempEnemy.GetComponent<DefualtEnemyController>().setHealth(9);
                tempEnemy.GetComponent<DefualtEnemyController>().setColor(EnemyTypes.RED);


                break;
        }
        
        tempEnemy.transform.parent = transform;
        tempEnemy.SetActive(false);
        return tempEnemy;
    }
}
