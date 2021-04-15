using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    GameObject castle;
    
    // Start is called before the first frame update
    void Start()
    {
        this.castle = GameObject.Find("Castle");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = Instantiate(arrowPrefab) as GameObject;
            float px = this.castle.transform.position.x;
            float py = this.castle.transform.position.y;
            go.transform.position = new Vector3(px, py, 0);
        }
    }
}
