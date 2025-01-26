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
        Vector2 worldpos = transform.position;
        if (screenpos.x < 0)
        {
            screenpos.x = Screen.width + 10;
            worldpos = Camera.main.ScreenToWorldPoint(screenpos);
        }
        else 
        {
            worldpos.x -= 1f * Time.deltaTime;
        }
        transform.position = worldpos;
    }
}
