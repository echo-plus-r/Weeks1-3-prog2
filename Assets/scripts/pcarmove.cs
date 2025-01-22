using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class pcarmove : MonoBehaviour
{
    public AnimationCurve curve;
    float t = 0.5f;

    // vel or velocity holds how fast the car will go each frame
    Vector2 vel = new Vector2(0, 0);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // defining a Vector2 to hold the position of the car, pos is short for position
        Vector2 pos = transform.position;

        // if statements for up and down ("W" and "S" keys) inputs
        if (Input.GetKey("w"))
        {
            pos.y += 1f * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= 1f * Time.deltaTime;
        }

        // if statements for left and right ("A" and "D" keys) inpute
        if (Input.GetKey("a"))
        {
            //pos.x -= 1f;

            // note that the number added is such that when a below else statement happens, the total amount added to t will be the same as "d" or right movement
            t -= 0.009f * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            //pos.x += 1f;
            t += 0.01f * Time.deltaTime;
        }

        // if the car is not actively speeding up, then it will slowly lose speed.
        else {
            t -= 0.001f * Time.deltaTime;
        }


        // commented out as it does not work as intended
        //pos = new Vector2(pos.x + (Mathf.Lerp(0, 1, curve.Evaluate(t))), pos.y);

        // using an animation curve to determine the car's horizontal velocity
        vel.x = Mathf.Lerp(-1, 1, curve.Evaluate(t));

        // making a Vector2 that contains the screen point of the position with the velocity added
        Vector2 posSP = Camera.main.WorldToScreenPoint(pos + vel);

        // checks if the car will go off screen
        // more accurately it checks if the position of the car when velocity is added will be off screen.
        if (posSP.x > 0 && posSP.x < Screen.width)
        {
            // adding the velocity to the position
            pos.x += vel.x;
        }

        // stopps the car from moving if it would otherwise go off screen
        // these values must be reset to avoid the car not moving when the button is pressed. 
        else {
            vel.x = 0;
            t = 0.5f;
        }


        // setting the cars position from pos
        transform.position = pos;
    }
}
