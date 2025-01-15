using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keymovement : MonoBehaviour
{
    //Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        if (Input.GetKey("w")) {
            pos.y += 0.005f;
            //rb.AddForce(transform.up * 2f);
        }
        if (Input.GetKey("s"))
        {
            pos.y -= 0.005f;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= 0.005f;
        }
        if (Input.GetKey("d"))
        {
            pos.x += 0.005f;
        }
        transform.position = pos;
    }
}
