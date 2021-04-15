using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarGenerator : MonoBehaviour
{
    public GameObject starPrefab;
    float span = 0;
    float delta = 0;

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
            GameObject go = Instantiate(starPrefab) as GameObject;
            int py = Random.Range(2, 5);
            go.transform.position = new Vector3(-12, py, 0);
            this.span = Random.Range(1.0f, 3.0f);
        }
    }
}
