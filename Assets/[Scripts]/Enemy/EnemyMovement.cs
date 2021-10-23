using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    GameObject enemyControl;
    [SerializeField] private Vector2[] target;
    private int targetCounter = 0;
    [SerializeField] private float tolerance = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        enemyControl = GameObject.Find("EnemyControl");
        transform.position = enemyControl.GetComponent<WayPointControl>().getSpawn();
        target = new Vector2[enemyControl.GetComponent<WayPointControl>().getAmountOfWayPoints()];
        for(int x = 0; x < target.Length; x++ )
        {
            target[x] = enemyControl.GetComponent<WayPointControl>().getWayPoint(x);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target[targetCounter], 1 * Time.deltaTime);
        if( Vector2.Distance(transform.position, target[targetCounter]) < tolerance)
        {
            targetCounter++;
        }
    }
}
