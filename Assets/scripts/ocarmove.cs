using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ocarmove : MonoBehaviour
{
    float cx;
    Boolean right = true;
    public AnimationCurve OtherCurve;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        // checks if the car is moving right (runs if "right" boolean is true)
        if (right)
        {
            // checks if "cx" float (handles animation curve result) is 1 or above
            if (cx >= 1)
            {
                // sets right boolean to false
                right = false;
            }

            // if "cx" float is below 1, it adds a little to the "cx" float
            else {
                cx += 0.1f * Time.deltaTime;
            }
        }

        // runs if the car is moving left
        else 
        {
            // checks if "cx" (handles animation curve result) float is 0 or under
            if (cx <= 0)
            {
                // sets the right boolean to true
                right = true;
            }

            // if "cx" float is above 0, removes a small amount from "cx"
            else
            {
                cx -= 0.1f * Time.deltaTime;
            }
        }

        // temporary numbers, use screen point position as the lerp should be between the left edge of the screen and the right edge of the screen
        pos.x = Mathf.Lerp(0, 10, OtherCurve.Evaluate(cx));
        transform.position = pos;
    }
}
