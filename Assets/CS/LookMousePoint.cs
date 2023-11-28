using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookMousePoint : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.mousePosition.x <Screen.width/2)
        {
            transform.localScale = new Vector2(-1, 1);
        }
else
        {
            transform.localScale = new Vector2(1, 1);
        }
    }
}
