using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keymovement : MonoBehaviour
{
    // speed is tied to how much the cube will move each frame if a button is pressed.
    public float speed;
    public AnimationCurve curve;
    Rigidbody2D rb;
    //Vector2 todd = new Vector2(0, 20);
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        // todd holds the force that's added to the ridged body when a button is pressed
        // isn't quite working yet. my goal is to have it add force baised on a curve, so that you can't fly by holding the up key.
        Vector2 todd = new Vector2(0, Mathf.Lerp(20, 0, curve.Evaluate(Time.frameCount)));
        if (Input.GetKey("w")) {
            pos.y += speed;
            //rb.AddForce(transform.up * 20f);
            //rb.AddForce(todd);
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
