///EnemyMovement
///101273089 Michael Shular
///Last modified: 10/23/2021
///
///Summary: This class manages the movement of the a enemy base of waypoints in the scene
///
///Revision History:
///0.1
///-the start fuction set up where the each way point for the enemy is
///-the update function move to the waypoint base off where the targetCounter is at 
///and the if statement increases targetCounter if the current target was reached 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    GameObject enemyControl;
    [SerializeField] private Vector2[] target;
    private int targetCounter = 0;
    [SerializeField] private float tolerance = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        enemyControl = GameObject.Find("EnemyControl");
        transform.position = enemyControl.GetComponent<WayPointControl>().getSpawn();
        target = new Vector2[enemyControl.GetComponent<WayPointControl>().getAmountOfWayPoints()];
        for(int x = 0; x < target.Length; x++ )
        {
            target[x] = enemyControl.GetComponent<WayPointControl>().getWayPoint(x);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target[targetCounter], 2 * Time.deltaTime);
        if( Vector2.Distance(transform.position, target[targetCounter]) < tolerance)
        {
            targetCounter++;
        }
    }
}
