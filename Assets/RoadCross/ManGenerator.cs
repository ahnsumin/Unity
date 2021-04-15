using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManGenerator : MonoBehaviour
{
    public GameObject gunmanPrefab;
    float span = 1.0f;
    float span_1 = 1.5f;
    float span_2 = 1.0f;
    float span_3 = 1.5f;
    float span_4 = 1.0f;
    float delta = 0;
    float delta_1 = 0;
    float delta_2 = 0;
    float delta_3 = 0;
    float delta_4 = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(gunmanPrefab) as GameObject;
            go.transform.position = new Vector3(-9, 7, 0);

            this.span = Random.Range(1.0f, 2.0f);
        }

        this.delta_1 += Time.deltaTime;
        if (this.delta_1 > this.span_1)
        {
            this.delta_1 = 0;
            GameObject go1 = Instantiate(gunmanPrefab) as GameObject;
            go1.transform.position = new Vector3(-1, 7, 0);

            this.span_1 = Random.Range(1.0f, 2.0f);
        }

        this.delta_2 += Time.deltaTime;
        if (this.delta_2 > this.span_2)
        {
            this.delta_2 = 0;
            GameObject go2 = Instantiate(gunmanPrefab) as GameObject;
            go2.transform.position = new Vector3(7, 7, 0);

            this.span_2 = Random.Range(1.0f, 2.0f);
        }

        this.delta_3 += Time.deltaTime;
        if (this.delta_3 > this.span_3)
        {
            this.delta_3 = 0;
            GameObject go3 = Instantiate(gunmanPrefab) as GameObject;
            go3.transform.position = new Vector3(15, 7, 0);

            this.span_3 = Random.Range(1.0f, 2.0f);
        }

        this.delta_4 += Time.deltaTime;
        if (this.delta_4 > this.span_4)
        {
            this.delta_4 = 0;
            GameObject go4 = Instantiate(gunmanPrefab) as GameObject;
            go4.transform.position = new Vector3(23, 7, 0);

            this.span_4 = Random.Range(1.0f, 2.0f);
        }
    }
}
