using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstscript : MonoBehaviour
{
    float speed = 0.01F;
    bool left = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("h[e]llo wo[r]ld");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        if (left) 
        {
            pos.x -= speed;
        }
        else
        {
            pos.x += speed;
        }

        if (pos.x > 10)
        {
            left = true;
        }
        if (pos.x < -10)
        {
            left = false;
        }
        
        transform.position = pos;
    }
}
