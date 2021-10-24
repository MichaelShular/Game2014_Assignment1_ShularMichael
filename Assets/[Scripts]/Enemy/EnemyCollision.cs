///EnemyCollision
///101273089 Michael Shular
///Last modified: 10/23/2021
///
///Summary: This class is used to control what happens when certain collisions with the enemy happen
///
///Revision History:
///0.1
///-added enemy collision with the goal and get added back to pool

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    private EnemyManager enemyManager;
    // Start is called before the first frame update
    void Start()
    {
        enemyManager = GameObject.Find("EnemyControl").GetComponent<EnemyManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "EnemyGoal")
        {
            enemyManager.ReturnEnemy(gameObject);
        }
    }
}
