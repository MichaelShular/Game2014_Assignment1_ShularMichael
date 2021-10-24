///EnemySpawnControl
///101273089 Michael Shular
///Last modified: 10/23/2021
///
///Summary: This class is used to control when the next enemy spawn will occur
///
///Revision History:
///0.1
///-get enemy for pool and a timer for the next spawn

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnControl : MonoBehaviour
{
    [SerializeField] private EnemyManager enemyManager;
    private float nextSpawnTime = 0;
    private float timeBetweenSpawns = 5;

    // Start is called before the first frame update
    void Start()
    {
        nextSpawnTime = timeBetweenSpawns;
    }

    // Update is called once per frame
    void Update()
    {
        if(nextSpawnTime <= Time.time)
        {
            nextSpawnTime = timeBetweenSpawns + Time.time;
            if(enemyManager.isQueueEmpty() == true)
            {
                enemyManager.GetEnemy();    
            }
        }
    }
}
