using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigerController : MonoBehaviour
{
    GameObject rabbit;
    // Start is called before the first frame update
    void Start()
    {
        this.rabbit = GameObject.Find("rabbitNoBag");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0);

        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.rabbit.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.6f;
        float r2 = 0.6f;

        if(d < r1 + r2)
        {
            Destroy(gameObject);
        }
    }
}
