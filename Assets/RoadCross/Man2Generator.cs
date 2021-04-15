using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man2Generator : MonoBehaviour
{
    public GameObject gunman2Prefab;
    float span = 1.0f;
    float span_1 = 1.5f;
    float span_2 = 1.0f;
    float span_3 = 1.5f;
    float delta = 0;
    float delta_1 = 0;
    float delta_2 = 0;
    float delta_3 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(gunman2Prefab) as GameObject;
            go.transform.position = new Vector3(-5, -7, 0);

            this.span = Random.Range(1.0f, 2.0f);
        }
        
        this.delta_1 += Time.deltaTime;
        if (this.delta_1 > this.span_1)
        {
            this.delta_1 = 0;
            GameObject go1 = Instantiate(gunman2Prefab) as GameObject;
            go1.transform.position = new Vector3(3, -7, 0);

            this.span_1 = Random.Range(1.0f, 2.0f);
        }

        this.delta_2 += Time.deltaTime;
        if (this.delta_2 > this.span_2)
        {
            this.delta_2 = 0;
            GameObject go2 = Instantiate(gunman2Prefab) as GameObject;
            go2.transform.position = new Vector3(11, -7, 0);

            this.span_2 = Random.Range(1.0f, 2.0f);
        }

        this.delta_3 += Time.deltaTime;
        if (this.delta_3 > this.span_3)
        {
            this.delta_3 = 0;
            GameObject go3 = Instantiate(gunman2Prefab) as GameObject;
            go3.transform.position = new Vector3(19, -7, 0);

            this.span_3 = Random.Range(1.0f, 2.0f);
        }
    }
}
