///TowerDetectionForBullets
///101273089 Michael Shular
///Last modified: 10/24/2021
///
///Summary: check if bullet can be fired for tower and damage enemy
///
///Revision History:
///0.1


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerDetectionForBullets : MonoBehaviour
{
    private BulletManager bulletManager;
    private bool canFire = false;
    [SerializeField] private float timeBetweenBulletFired;
    private float nextBulletToFireTime;
    private Transform target;
    private EnemyTypes enemiesColor;
    private EnemyTypes TowerColor = EnemyTypes.NONE;

    // Start is called before the first frame update
    void Start()
    {
        bulletManager = GameObject.Find("TowerBulletManager").GetComponent<BulletManager>();
        nextBulletToFireTime = timeBetweenBulletFired;
    }

    // Update is called once per frame
    void Update()
    {
        TowerColor = this.GetComponentInParent<TowerController>().currentColorForTower;

        if (canFire && enemiesColor == TowerColor)
        {
            if(nextBulletToFireTime <= Time.time)
            {
                nextBulletToFireTime = timeBetweenBulletFired + Time.time;
                bulletManager.getBullet(transform.position, TowerColor, target);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        canFire = true;
        target = collision.transform;
        enemiesColor = collision.GetComponent<DefualtEnemyController>().getColor();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canFire = false;
    }
}
