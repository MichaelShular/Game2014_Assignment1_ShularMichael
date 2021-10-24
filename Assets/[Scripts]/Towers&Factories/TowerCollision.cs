///MaterialFactoryController
///101273089 Michael Shular
///Last modified: 10/24/2021
///
///Summary: Used to contol what happens when certain collisions with the tower happen
///
///Revision History:
///0.1
///-deletes itself if collsion happens
///-need to change tag so placed towers done also delete


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCollision : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("TowerButtons").GetComponent<TowerButtons>().isTowerBeingDragged())
        {
            Invoke("delayedTagChange", 1.0f);
        }
            
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!GameObject.Find("TowerButtons").GetComponent<TowerButtons>().isTowerBeingDragged())
        {
            if(this.tag == "Tower")
            {
                Destroy(this.gameObject);
            }
        }
    }

    private void delayedTagChange()
    {
        gameObject.tag = "TowerChange";
    }
}
