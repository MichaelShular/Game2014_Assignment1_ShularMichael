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
