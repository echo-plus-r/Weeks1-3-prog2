using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    // defining animation curve
    public AnimationCurve jcurve;

    // defining timer float, this handles time and it's relation to the curve
    float timer = 1f;

    // defining Vector2 start, this holds the position of the square when space is pressed
    Vector2 start;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // defining pos, short for position, holds the square's position
        Vector2 Pos = transform.position;

        // defining rot, short for rotation, holds the square's rotation
        Vector2 rot = transform.eulerAngles;

        // checking if space has been pressed
        if (Input.GetKey(KeyCode.Space)) {
            timer = 0f; // resetting the timer
            start.y = Pos.y; // setting the starting position
        }

        // checks if the timer is over or running
        if (timer < 1) {

            // broken and commented out code
            //Pos.y += jcurve.Evaluate(timer);
            //Pos.y = jcurve.Evaluate(timer) - Pos.y;
            //Debug.Log((jcurve.Evaluate(timer)) + "=" + (jcurve.Evaluate(timer) - Pos.y));

            // sets the y position based on the starting position and what value the curve is based on the timer
            Pos.y = start.y + jcurve.Evaluate(timer);

            // sets the x rotation baised on the value of the curve based on the timer. it's also interpalated so it returns a value between 0 and 180.
            rot.x = Mathf.Lerp(0, 180, jcurve.Evaluate(timer));


            // adds 0.5 to the timer that controls the curve. i can't explain exsactly what this does, or why time.deltatime is there, but it works.
            timer += 0.5f * Time.deltaTime;
        }

        // fully setting the position and rotation, this has to be done due to something with unity
        transform.position = Pos;
        transform.eulerAngles = rot;
    }
}
