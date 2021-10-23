using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Using manager from class as example

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
}
