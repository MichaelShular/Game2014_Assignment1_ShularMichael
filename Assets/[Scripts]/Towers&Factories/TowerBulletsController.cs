///TowerBulletController
///101273089 Michael Shular
///Last modified: 10/24/2021
///
///Summary: Used to contol behaviour of bullets that towers use such as movement, damage or color
///
///Revision History:
///0.1
///-

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBulletsController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float damage;
    private EnemyTypes colorType = EnemyTypes.NONE;
    private Vector2 target; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    private void move()
    {
        //transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        transform.position += new Vector3(speed, 0.0f, 0.0f) * Time.deltaTime;
    }

    public void setTarget(Vector2 a)
    {
        target = a;
    }

    public void setColor(EnemyTypes a)
    {
        colorType = a;
    }
}
