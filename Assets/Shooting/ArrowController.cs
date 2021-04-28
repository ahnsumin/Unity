using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    float moveSpeed = 20.0f;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);

        if(transform.position.y > 5.0f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "star")
        {
            Debug.Log("º°");

            GameObject director = GameObject.Find("ArrowCountDirector");
            director.GetComponent<ArrowCountDirector>().IncreaseCount();

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
