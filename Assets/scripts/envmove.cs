using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class envmove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 screenpos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenpos.x < 0)
        {
            screenpos.x = Screen.width + 10;
        }
        else 
        {
            screenpos.x += 1;
        }
        transform.position = screenpos;
    }
}
