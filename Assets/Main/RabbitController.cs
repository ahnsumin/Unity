using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float walkForce = 30.0f;
    float maxWalkSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        if(speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        if(transform.position.x < -13)
        {
            transform.position = new Vector3(-5, -3, 0);
            key = 0;
        }

        if (transform.position.x > 55)
        {
            transform.position = new Vector3(50, -3, 0);
            key = 0;
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key * 0.26058f, 0.26058f, 1);
        }
    }
}
