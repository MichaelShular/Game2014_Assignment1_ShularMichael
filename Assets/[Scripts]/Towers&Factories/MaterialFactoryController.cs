///MaterialFactoryController
///101273089 Michael Shular
///Last modified: 10/23/2021
///
///Summary: Used to contol what the material factory does in game
///
///Revision History:
///0.1
///-increase the amount material which is used to build towers/factories

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialFactoryController : MonoBehaviour
{
    private PlayerController playerController;
    private float timeUntilNextMaterial = 0;
    [SerializeField]private float timeBetweenMaterials = 6;
    // Start is called before the first frame update
    void Start()
    {
        timeUntilNextMaterial = timeBetweenMaterials;
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeUntilNextMaterial <= Time.time)
        {
            timeUntilNextMaterial = timeBetweenMaterials + Time.time;
            int temp = playerController.getNumberOfMaterials();
            temp++;
            playerController.setNumberOfMaterials(temp);
        }

    }
}
