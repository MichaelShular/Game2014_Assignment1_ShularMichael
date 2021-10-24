///PlayerController
///101273089 Michael Shular
///Last modified: 10/23/2021
///
///Summary: Used to contol player variables like lives and building material 
///
///Revision History:
///0.1
///-get and sets numberOfLives and numberOfMaterials
///-update the UI labels in scene

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private int numberOfLives;
    [SerializeField] private int numberOfMaterials;
    [SerializeField] private TextMeshProUGUI uILives;
    [SerializeField] private TextMeshProUGUI uICost;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        uILives.text = numberOfLives.ToString();
            
        uICost.text = numberOfMaterials.ToString();
    }
    public int getLives()
    {
        return numberOfLives;
    }
    public int getNumberOfMaterials()
    {
        return numberOfMaterials;
    }
    public void setLives(int a)
    {
       numberOfLives = a;
    }
    public void setNumberOfMaterials(int a)
    {
        numberOfMaterials = a;
    }
}
