using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man2Controller : MonoBehaviour
{
    float upForce = 0;
    Rigidbody2D rigid2D;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        this.upForce = 10.0f;
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float speedy = Mathf.Abs(this.rigid2D.velocity.y);

        this.rigid2D.AddForce(transform.up * 1 * this.upForce);

        this.animator.speed = speedy / 50.0f;

        //this.downForce = Random.Range(10.0f, 15.0f);

        if (transform.position.y > 5.0f)
        {
            Destroy(gameObject);
        }
    }
}
