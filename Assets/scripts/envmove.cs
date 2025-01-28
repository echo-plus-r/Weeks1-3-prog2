using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class envmove : MonoBehaviour
{
    // speed handles how many units the environment/parent object will move each frame
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // screen pos holds the screen position of the environment parent object
        Vector2 screenpos = Camera.main.WorldToScreenPoint(transform.position);

        // world pos holds the world position of the environment parent object
        Vector2 worldpos = transform.position;

        // checks if the parent object has moved 10 units to the left
        // 10 units are where the sprites loop, so that's why it checks for 10 units
        if (worldpos.x < -10) {

            // resetting world position
            worldpos.x = 0;
        }

        // adding the speed to the world position
        worldpos.x -= speed * Time.deltaTime;

        // setting the parent object's position
        transform.position = worldpos;
    }
}
