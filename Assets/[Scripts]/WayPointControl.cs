///WayPointControl
///101273089 Michael Shular
///Last modified: 10/23/2021
///
///Summary: Class is used manage the positions in a level where enemies will head towards and are 
///mainly managed within the unity inspector
///
///Revision History:
///0.1
///-wayPoint holds the transform's of the game objects "waypoint" in the scene
///-spawnPoint hold the transform of where enemy will spawn
///-getAmountOfWayPoints function get how many way points are in the level
///-

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointControl : MonoBehaviour
{
    [SerializeField] public Transform[] wayPoint;
    [SerializeField] public Transform spawnPoint;
    // Start is called before the first frame update
    public Vector2 getWayPoint(int a)
    {
        return wayPoint[a].position;
    }

    public int getAmountOfWayPoints()
    {
        return wayPoint.Length;
    }
    public Vector2 getSpawn()
    {
        return spawnPoint.position;
    }
}
