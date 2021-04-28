using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RamdomPlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 780.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 3.0f;
    bool isJump;
    public bool roulette;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
        this.roulette = false;
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
            transform.localScale = new Vector3(key * 2.0f, 2, 1);
        }

        this.animator.speed = speedx / 2.0f;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "ground")
        {
            this.isJump = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "water")
        {
            Debug.Log("¾ð´õ´õ¾¾");
            SceneManager.LoadScene("GameOver");
            DontDestroyOnLoad(GameObject.Find("MainTime"));

            if (SceneManager.GetActiveScene().name == "GameOver")
            {
                Destroy(GameObject.Find("Maintime"));
            }
        }
        else
        {
            this.roulette = true;
        }
    }
}
