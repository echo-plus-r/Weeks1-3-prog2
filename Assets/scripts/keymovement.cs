using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keymovement : MonoBehaviour
{
    public float speed;
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
            pos.y += speed;
            //rb.AddForce(transform.up * 2f);
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed;
        }
        transform.position = pos;
    }
}
