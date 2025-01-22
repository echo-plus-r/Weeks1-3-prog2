using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pcarmove : MonoBehaviour
{
    public AnimationCurve curve;
    float t = 0.5f;
    Vector2 vel = new Vector2(0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        if (Input.GetKey("w"))
        {
            pos.y += 1f * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= 1f * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            //pos.x -= 1f;
            t -= 0.009f * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            //pos.x += 1f;
            t += 0.01f * Time.deltaTime;
        }
        else {
            t -= 0.001f * Time.deltaTime;
        }


        // commented out as it does not work as intended
        //pos = new Vector2(pos.x + (Mathf.Lerp(0, 1, curve.Evaluate(t))), pos.y);

        vel.x = Mathf.Lerp(-1, 1, curve.Evaluate(t));

        pos.x += vel.x;


        transform.position = pos;
    }
}
