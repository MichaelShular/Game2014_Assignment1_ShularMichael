///BulletFactory
///101273089 Michael Shular
///Last modified: 10/24/2021
///
///Summary: Class is used for the Instantiate of bullets 
///
///Revision History:
///0.1 creates bullet fuction

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BulletFactory : MonoBehaviour
{
    public GameObject Bullet;

    public GameObject createBullet()
    {
        GameObject tempBullet = null;

        tempBullet = Instantiate(Bullet);
        tempBullet.transform.parent = transform;
        tempBullet.SetActive(false);
        return tempBullet;
    }
}
