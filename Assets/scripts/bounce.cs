using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    public Vector2 basespeed;
    private Vector2 speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = basespeed;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        Vector2 squarescreenspace = Camera.main.WorldToScreenPoint(pos);

        // this seems to run every frame after 'a' or 'd' is pressed. i don't know why
        if (Input.GetAxis("Horizontal") != 0)
        {
            basespeed.x += Input.GetAxis("Horizontal") / 1000;
            speed = basespeed;
        }

        if (squarescreenspace.x + speed.x < 0 || squarescreenspace.x + speed.x > Screen.width)
        {
            speed.x *= -1;
        }
        if (squarescreenspace.y + speed.y < 0 || squarescreenspace.y + speed.y > Screen.height)
        {
            speed.y *= -1;
        }

        
        

        pos += speed;

        transform.position = pos;
    }
}
