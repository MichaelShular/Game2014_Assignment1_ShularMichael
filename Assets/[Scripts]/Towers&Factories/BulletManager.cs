///BulletManager
///101273089 Michael Shular
///Last modified: 10/24/2021
///
///Summary: used to control the bullet to and from a queue 
///
///Revision History:
///0.1
///-build pool, dequeue bullet, return bullet

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BulletManager : MonoBehaviour
{
    public BulletFactory bulletFactory;
    private Queue<GameObject> bulletPool;
    [SerializeField] private int amountOfBullets;

    // Start is called before the first frame update
    void Start()
    {
        buildBulletPool();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void buildBulletPool()
    {
        bulletPool = new Queue<GameObject>();

        for (int i = 0; i < amountOfBullets; i++)
        {
            var tempBullet = bulletFactory.createBullet();
            bulletPool.Enqueue(tempBullet);
        }
    }

    public GameObject getBullet(Vector2 spawnLocation, EnemyTypes color, Transform target)
    {
        var tempBullet = bulletPool.Dequeue();
        tempBullet.SetActive(true);
        tempBullet.transform.position = spawnLocation;
        tempBullet.GetComponent<TowerBulletsController>().setColor(color);
        tempBullet.GetComponent<TowerBulletsController>().setTarget(target);
        return tempBullet;
    }

    public void returnBullet(GameObject a)
    {
        a.SetActive(false);
        bulletPool.Enqueue(a);
    }


}
