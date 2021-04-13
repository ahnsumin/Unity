using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject circle;
    GameObject line;
    GameObject distance;

    // Start is called before the first frame update
    void Start()
    {
        this.circle = GameObject.Find("circle");
        this.line = GameObject.Find("line");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.line.transform.position.x - this.circle.transform.position.x;
        this.distance.GetComponent<Text>().text = "목표 지점까지 " + length.ToString("F1") + "m";
    }
}
