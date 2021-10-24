using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerDetectionForBullets : MonoBehaviour
{
    private BulletManager bulletManager;
    private bool canFire = false;
    [SerializeField] private float timeBetweenBulletFired;
    private float nextBulletToFireTime;
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = GameObject.Find("TowerBulletManager").GetComponent<BulletManager>();
        nextBulletToFireTime = timeBetweenBulletFired;
    }

    // Update is called once per frame
    void Update()
    {
        if (canFire)
        {
            if(nextBulletToFireTime <= Time.time)
            {
                nextBulletToFireTime = timeBetweenBulletFired + Time.time;
                bulletManager.getBullet(transform.position, EnemyTypes.BLUE, Vector2.zero);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canFire = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canFire = false;
    }
}
