using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigerGenerator : MonoBehaviour
{
    public GameObject tigerPrefab;
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
            GameObject go = Instantiate(tigerPrefab) as GameObject;
            int px = Random.Range(-9, 10);
            go.transform.position = new Vector3(px, 7, 0);

            this.span = Random.Range(0.3f, 0.5f);
        }
    }
}
