///TowerCost
///101273089 Michael Shular
///Last modified: 10/24/2021
///
///Summary: Just hold the cost to build for all towers
///
///Revision History:
///0.1
///-returns a tower build cost

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCost : MonoBehaviour
{
    [SerializeField] int[] towerCosts;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getTowerCost(int a)
    {
        return towerCosts[a];
    }
}
