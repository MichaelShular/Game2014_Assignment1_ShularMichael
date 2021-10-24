///EnemyCollision
///101273089 Michael Shular
///Last modified: 10/23/2021
///
///Summary: This class is used to control what happens when certain collisions with the enemy happen
///
///Revision History:
///0.1
///-added enemy collision with the goal and get added back to pool
///0.2
///-change lives enemy collision happens 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    private EnemyManager enemyManager;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
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
            GameObject.Find("Player").GetComponent<PlayerController>().incrementNumberOfEnemysDefeated();
            int temp = playerController.getLives();
            temp--;
            playerController.setLives(temp);
            enemyManager.ReturnEnemy(gameObject);
        }
    }
}
