using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButtonScript : MonoBehaviour
{
    [SerializeField] private EnemyTypes color;
    private GameObject currentColorFactory;
    Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        GameObject.Find("Player").GetComponent<PlayerController>().choosenColor = color;
        foreach (var a in GameObject.FindGameObjectsWithTag("ColorButton"))
        {
            a.GetComponent<ColorButtonScript>().ResetPosition();
        }
        
    }

    public void currentFactory(GameObject a)
    {
        currentColorFactory = a;
    }

    public void ResetPosition()
    {
        transform.position = startPosition;
    }

}
