using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatController : MonoBehaviour
{
    float px = 0;
    float py = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.px = transform.position.x;
        this.py = transform.position.y;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-2, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(2, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0, 1, 0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0, -1, 0);
        }

        if (this.px < -12 || this.py <= -5 || this.py >= 5)
        {
            transform.position = new Vector3(-11, 0, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "gunman1" || other.gameObject.tag == "gunman2")
        {
            Debug.Log("게임오버");
            SceneManager.LoadScene("GameOver");
        }
        if(other.gameObject.tag == "ending")
        {
            Debug.Log("성공");
            SceneManager.LoadScene("GameEnding");
        }
    }
}
