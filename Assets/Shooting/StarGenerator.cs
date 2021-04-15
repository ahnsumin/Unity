using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarGenerator : MonoBehaviour
{
    public GameObject starPrefab;
    float span = 3.0f;
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
            int px = Random.Range(-12, 12);
            int py = Random.Range(2, 5);
            go.transform.position = new Vector3(px, py, 0);
        }
    }
}
