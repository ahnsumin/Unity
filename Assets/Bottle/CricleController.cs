using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CricleController : MonoBehaviour
{
    float speed = 0;
    float start = 0;
    GameObject line;
    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        this.start = transform.position.x;
        this.line = GameObject.Find("line");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        } else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = (endPos.x - this.startPos.x);

            this.speed = swipeLength / 500.0f;
        }

        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;

        float length = this.line.transform.position.x - transform.position.x;

        if (this.speed < 0.00001 && this.speed != 0)
        {
            this.speed = 0;
            if (transform.position.x > 10)
            {
                transform.localPosition = new Vector3(start, 0, 0);
                int px = Random.Range(0, 7);
                this.line.transform.position = new Vector3(px, 0, 0);
                Debug.Log("실패");
            }
            else if (length > 0)
            {
                transform.localPosition = new Vector3(start, 0, 0);
                int px = Random.Range(0, 7);
                this.line.transform.position = new Vector3(px, 0, 0);
                Debug.Log("실패");
            }
            else
            {
                SceneManager.LoadScene("GameEnding");
            }
        }
    }
}
