///TowerController
///101273089 Michael Shular
///Last modified: 10/24/2021
///
///Summary: a class use to control parts of a tower. Mainly used to control and apply color to current tower 
///
///Revision History:
///0.1
///-apply and save color 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    // Start is called before the first frame update
    public EnemyTypes currentColorForTower;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        currentColorForTower = GameObject.Find("Player").GetComponent<PlayerController>().choosenColor;
        GameObject.Find("Player").GetComponent<PlayerController>().choosenColor = EnemyTypes.NONE;
        Time.timeScale = 1;
    }
}
