using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefualtEnemyController : MonoBehaviour
{
    [SerializeField] private float health;
    private EnemyTypes enemyColor = EnemyTypes.NONE;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
