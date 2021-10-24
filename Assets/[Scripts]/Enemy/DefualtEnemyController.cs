using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefualtEnemyController : MonoBehaviour
{
    private EnemyManager enemyManager;
    [SerializeField] private float health;
    private EnemyTypes enemyColor = EnemyTypes.NONE;
    // Start is called before the first frame update
    void Start()
    {
        enemyManager = GameObject.Find("EnemyControl").GetComponent<EnemyManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            GameObject.Find("Player").GetComponent<PlayerController>().incrementNumberOfEnemysDefeated();
            enemyManager.ReturnEnemy(this.gameObject);
        }
    }

    public void setHealth(float a)
    {
        health = a;
    }
    public float getHealth()
    {
        return health;
    }

    public void setColor(EnemyTypes a)
    {
        enemyColor = a;
    }
    public EnemyTypes getColor()
    {
        return enemyColor;
    }


}
