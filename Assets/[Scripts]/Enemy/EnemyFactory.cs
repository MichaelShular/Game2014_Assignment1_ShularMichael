using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Using Factory from class as example
/// 
/// </summary>
[System.Serializable]
public class EnemyFactory : MonoBehaviour
{
    public GameObject redEnemy;
    public GameObject blueEnemy;
    public GameObject greenEnemy;
    public GameObject createEnemy(EnemyTypes enemy)
    {
        GameObject tempEnemy = null;
        switch (enemy)
        {
            case EnemyTypes.BLUE:
                tempEnemy = Instantiate(blueEnemy);
                break;
            case EnemyTypes.GREEN:
                tempEnemy = Instantiate(greenEnemy);
                break;
            case EnemyTypes.RED:
                tempEnemy = Instantiate(redEnemy);
                break;
        }
        tempEnemy.SetActive(false);
        tempEnemy.transform.parent = transform;
        return tempEnemy;
    }
}
