using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsForEachLevel : MonoBehaviour
{
    [SerializeField] private SpriteRenderer[] star;



    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < PlayerPrefs.GetInt("Level1"); i++)
        {
            star[i].enabled = true;
        }
        for (int i = 3; i < PlayerPrefs.GetInt("Level2"); i++)
        {
            star[i].enabled = true;
        }
        for (int i = 6; i < PlayerPrefs.GetInt("Level3"); i++)
        {
            star[i].enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
