using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public AnimationCurve jcurve;
    float timer = 1f;
    Vector3 start;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Pos = transform.position;
        if (Input.GetKey(KeyCode.Space)) {
            timer = 0f;
            start.y = Pos.y;
            start.z = Pos.z;
        }
        if (timer < 1) {
            //Pos.y += jcurve.Evaluate(timer);
            //Pos.y = jcurve.Evaluate(timer) - Pos.y;
            //Debug.Log((jcurve.Evaluate(timer)) + "=" + (jcurve.Evaluate(timer) - Pos.y));
            Pos.y = start.y + jcurve.Evaluate(timer);
            Pos.z = start.z + jcurve.Evaluate(timer);


            timer += 0.5f * Time.deltaTime;
        }
        transform.position = Pos;
    }
}
