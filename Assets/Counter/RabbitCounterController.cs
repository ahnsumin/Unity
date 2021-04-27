using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RabbitCounterController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float jumpForce = 780.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    bool isJump;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.isJump = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && this.isJump == false)
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
            this.isJump = true;
        }

        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        if(speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        if(key != 0)
        {
            transform.localScale = new Vector3(key * 0.26058f, 0.26058f, 1);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            this.isJump = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("°è»ê");
        SceneManager.LoadScene("Ending");
    }
}
