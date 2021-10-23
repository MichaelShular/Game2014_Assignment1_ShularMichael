using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    GameObject eventSystem;
    [SerializeField] private Vector2[] target;
    private int targetCounter = 0;
    [SerializeField] private float tolerance = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        eventSystem = GameObject.Find("EventSystem");
        transform.position = eventSystem.GetComponent<WayPointControl>().getSpawn();
        target = new Vector2[eventSystem.GetComponent<WayPointControl>().getAmountOfWayPoints()];
        for(int x = 0; x < target.Length; x++ )
        {
            target[x] = eventSystem.GetComponent<WayPointControl>().getWayPoint(x);
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
