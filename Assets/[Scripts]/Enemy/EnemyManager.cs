///EnemyManager
///101273089 Michael Shular
///Last modified: 10/23/2021
///
///Summary: Class is used to manage the what type of enemies will spawn and hold
///them in a queue when the object are not active
///
///Revision History:
///0.1
///-listOfEnemysForLevel variable will manage the enemies for each level from within the unity inspector
///-_BuildBulletPool function creates the queue to hold the enemy passes the information of which enemy need to be created
///-GetEnemy function makes the enemy within the pool active 
///-ReturnEnemy fucntion returns the enemy to the queue and makes it not active
///0.2
///-isQueueEmpty returns is there is something in the pool 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyManager : MonoBehaviour
{
    public EnemyFactory enemyFactory;
    [SerializeField] EnemyTypes[] listOfEnemysForLevel;
    private Queue<GameObject> m_EnemyPool;

    // Start is called before the first frame update
    void Start()
    {
        _BuildBulletPool();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void _BuildBulletPool()
    {
        m_EnemyPool = new Queue<GameObject>();
        for (int x = 0; x < listOfEnemysForLevel.Length; x++)
        {
            var tempEnemy = enemyFactory.createEnemy(listOfEnemysForLevel[x]);
            m_EnemyPool.Enqueue(tempEnemy);
        }
    }
    public GameObject GetEnemy()
    {
        var tempEnemy = m_EnemyPool.Dequeue();
        tempEnemy.SetActive(true);
        return tempEnemy;
    }
    public void ReturnEnemy(GameObject returnedEnemy)
    {
        returnedEnemy.SetActive(false);
        m_EnemyPool.Enqueue(returnedEnemy);
    }
    public bool isQueueEmpty()
    {
        if(m_EnemyPool.Count > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public int getNumberOfEnemyInlevel()
    {
        return listOfEnemysForLevel.Length;
    }
}
