using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class castleController : MonoBehaviour
{
    GameObject arrow;

    // Start is called before the first frame update
    void Start()
    {
        this.arrow = GameObject.Find("arrow");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 arrowPos = this.arrow.transform.position;
        transform.position = new Vector3(
            arrowPos.x, transform.position.y, transform.position.z);
    }
}
