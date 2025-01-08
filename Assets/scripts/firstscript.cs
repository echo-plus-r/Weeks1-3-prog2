using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstscript : MonoBehaviour
{
    float speed = 0.01F;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("h[e]llo wo[r]ld");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        Vector2 squarescreenspace = Camera.main.WorldToScreenPoint(pos);

        if (squarescreenspace.x < 0 || squarescreenspace.x > Screen.width)
        {
            speed *= -1;
        }

        pos.x += speed;

        transform.position = pos;
    }
}
