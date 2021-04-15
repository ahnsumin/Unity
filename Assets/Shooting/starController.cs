using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -5);

        float speed = Random.Range(0.075f, 0.2f);
        transform.position += new Vector3(speed, 0, 0);

        if (transform.position.x > 13.0f)
        {
            Destroy(gameObject);
        }
    }
}
