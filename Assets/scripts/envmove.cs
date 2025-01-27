using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class envmove : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 screenpos = Camera.main.WorldToScreenPoint(transform.position);
        Vector2 worldpos = transform.position;
        if (worldpos.x < -10) {
            worldpos.x = 0;
        }
        /*
        if (screenpos.x < 0)
        {
            screenpos.x = Screen.width;
            worldpos = Camera.main.ScreenToWorldPoint(screenpos);
        }
        else 
        {
            worldpos.x -= speed * Time.deltaTime;
        }
        */
        worldpos.x -= speed * Time.deltaTime;
        transform.position = worldpos;
    }
}
