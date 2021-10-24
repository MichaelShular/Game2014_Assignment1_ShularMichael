///Towerbuttons
///101273089 Michael Shular
///Last modified: 10/24/2021
///
///Summary: This code is so when the player selects tower for menu they can 
///drag it out on to the game screen
///
///Revision History:
///0.1
///-tower is created and moves during drag
///-need to expend to multiple tower
///-need to add to only grass

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
    [SerializeField] GameObject colorFactory;
    [SerializeField] GameObject materialFactory;

    private Vector3 m_touchesEnded;
    GameObject tempTower;
    private enum towerTypes
    {
        FIRE, MATERIALFACTORY, COLOR, NONE
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
        //Debug.Log(isTouchingButton);
        if (isTouchingButton)
        {
            Move();
            switch (currentTowerChoosen)
            {
                case towerTypes.FIRE:
                    temporayMovingTower.position = m_touchesEnded;
                    break;
                case towerTypes.MATERIALFACTORY:
                    temporayMovingTower.position = m_touchesEnded;
                    break;
                case towerTypes.COLOR:
                    temporayMovingTower.position = m_touchesEnded;
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
        tempTower = Instantiate(fireTower);
        temporayMovingTower = tempTower.transform;
    }

    public void createFacoryColor()
    {
        currentTowerChoosen = towerTypes.COLOR;
        isTouchingButton = true;
        GameObject.Find("TowerButtons").GetComponent<Canvas>().enabled = false;
        tempTower = Instantiate(colorFactory);
        temporayMovingTower = tempTower.transform;
    }

    public void createFactoryMaterial()
    {
        currentTowerChoosen = towerTypes.MATERIALFACTORY;
        isTouchingButton = true;
        GameObject.Find("TowerButtons").GetComponent<Canvas>().enabled = false;
        tempTower = Instantiate(materialFactory);
        temporayMovingTower = tempTower.transform;
    }


    private void Move()
    {
        foreach (var touch in Input.touches)
        {
            var worldTouch = new Vector3(Camera.main.ScreenToWorldPoint(touch.position).x, 
                Camera.main.ScreenToWorldPoint(touch.position).y);
            m_touchesEnded = worldTouch;
            if (touch.phase == TouchPhase.Ended)
            {
                currentTowerChoosen = towerTypes.NONE;
                isTouchingButton = false;
            }

        }
    }
    public bool isTowerBeingDragged()
    {
        return isTouchingButton;
    }
}
