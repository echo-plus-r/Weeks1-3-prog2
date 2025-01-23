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

        // converts the position into a screen point
        pos = Camera.main.WorldToScreenPoint(pos);

        // evaluating the curve and interpolating it between the horizontal edges of the screen
        pos.x = Mathf.Lerp(0, Screen.width, OtherCurve.Evaluate(cx));

        // defining a new Vector2 and setting it's value to the world point of pos
        // note that pos needs to be passed to another Vector2 due to some z axis or Vector3 nonsence
        Vector2 fpos = Camera.main.ScreenToWorldPoint(pos);

        // setting the car's position
        transform.position = fpos;
    }
}
