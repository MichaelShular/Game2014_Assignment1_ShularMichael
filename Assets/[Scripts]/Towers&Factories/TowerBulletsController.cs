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
    private BulletManager bulletManager;
    [SerializeField] float speed;
    [SerializeField] float damage;
    private EnemyTypes colorType = EnemyTypes.NONE;
    private Transform target;
    [SerializeField] private Bounds bulletBoundsX;
    [SerializeField] private Bounds bulletBoundsY;


    // Start is called before the first frame update
    void Start()
    {
        bulletManager = GameObject.Find("TowerBulletManager").GetComponent<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
        checkBounds();
    }

    private void move()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        //transform.position += new Vector3(speed, 0.0f, 0.0f) * Time.deltaTime;
    }

    private void checkBounds()
    {
        if (transform.position.x < bulletBoundsX.min || transform.position.x > bulletBoundsX.max)
        {
            bulletManager.returnBullet(this.gameObject);
        }
        if (transform.position.y < bulletBoundsY.min || transform.position.y > bulletBoundsY.max)
        {
            bulletManager.returnBullet(this.gameObject);
        }

    }
    public void setTarget(Transform a)
    {
        target = a;
    }

    public void setColor(EnemyTypes a)
    {
        switch (a)
        {
            case EnemyTypes.RED:
                this.GetComponent<SpriteRenderer>().color = new Color32(0, 0, 0, 255) + GameObject.Find("EnemyControl").GetComponent<EnemyManager>().listOfColors(0);
                break;
            case EnemyTypes.BLUE:
                this.GetComponent<SpriteRenderer>().color = new Color32(0, 0, 0, 255) + GameObject.Find("EnemyControl").GetComponent<EnemyManager>().listOfColors(1);
                break;
            case EnemyTypes.GREEN:
                this.GetComponent<SpriteRenderer>().color = new Color32(0, 0, 0, 255) + GameObject.Find("EnemyControl").GetComponent<EnemyManager>().listOfColors(2);
                break;
            case EnemyTypes.NONE:
                break;
            default:
                break;
        }
        colorType = a;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<DefualtEnemyController>().getColor() == colorType)
        {

            float temphealth = collision.GetComponent<DefualtEnemyController>().getHealth() - 3;
            Debug.Log(temphealth);
            collision.GetComponent<DefualtEnemyController>().setHealth(temphealth);
        }
        bulletManager.returnBullet(this.gameObject);
    }
}
