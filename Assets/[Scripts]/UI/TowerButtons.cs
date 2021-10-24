using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerButtons : MonoBehaviour
{
    [SerializeField] ButtonsForSceneControl buttonsForSceneControl;
    private bool isTouchingButton;
    private Transform temporayMovingTower;
    private Touch touch;
    [SerializeField] GameObject fireTower;
    private Vector3 m_touchesEnded;
    private enum towerTypes
    {
        FIRE, MATERIALFACTORY, NONE
    }
    private towerTypes currentTowerChoosen;

    // Start is called before the first frame update
    void Start()
    {
        isTouchingButton = false;
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (isTouchingButton)
        {
            
            switch (currentTowerChoosen)
            {
                case towerTypes.FIRE:
                    temporayMovingTower.position = m_touchesEnded;
                    if (touch.phase == TouchPhase.Ended)
                    {
                        currentTowerChoosen = towerTypes.NONE;
                        Debug.Log("end");
                    }
                    break;
                case towerTypes.MATERIALFACTORY:
                    break;
                case towerTypes.NONE:
                    break;
                default:
                    break;
            }
        }
    }

    public void createTowerFire()
    {
        currentTowerChoosen = towerTypes.FIRE;
        isTouchingButton = true;
        GameObject.Find("TowerButtons").GetComponent<Canvas>().enabled = false;
        GameObject temp = Instantiate(fireTower);

        temporayMovingTower = temp.transform;

        if (Input.touchCount > 0)
        {    
            touch = Input.GetTouch(0);
            Debug.Log(touch.position);
        }
    }

    private void Move()
    {
        foreach (var touch in Input.touches)
        {
            var worldTouch = new Vector3(Camera.main.ScreenToWorldPoint(touch.position).x, 
                Camera.main.ScreenToWorldPoint(touch.position).y);
            m_touchesEnded = worldTouch;
        }
    }
}
