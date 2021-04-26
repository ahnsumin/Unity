using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCameraController : MonoBehaviour
{
    GameObject redcar;
    // Start is called before the first frame update
    void Start()
    {
        this.redcar = GameObject.Find("redcar");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 redcarPos = this.redcar.transform.position;
        transform.position = new Vector3(
            redcarPos.x, transform.position.y, transform.position.z);
    }
}
