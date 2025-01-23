using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ocarmove : MonoBehaviour
{
    float cx;
    public AnimationCurve OtherCurve;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;


        // checks if "cx" float (handles animation curve result) is 1 or above
        if (cx >= 1)
        {
            cx = 0;
        }

        // if "cx" float is below 1, it adds a little to the "cx" float
        else 
        {
            cx += 0.1f * Time.deltaTime;
        }

        

        // temporary numbers, use screen point position as the lerp should be between the left edge of the screen and the right edge of the screen
        pos.x = Mathf.Lerp(0, 10, OtherCurve.Evaluate(cx));
        transform.position = pos;
    }
}
