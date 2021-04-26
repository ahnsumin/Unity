using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RouletteCountDirector : MonoBehaviour
{
    int count = 0;
    GameObject Count;

    // Start is called before the first frame update
    void Start()
    {
        this.Count = GameObject.Find("Count");
    }

    // Update is called once per frame
    void Update()
    {
        this.count = GameObject.Find("roulette").GetComponent<RouletteController>().count;
        this.Count.GetComponent<Text>().text = "³²Àº È½¼ö: " + this.count.ToString("F0") + "¹ø";
    }
}
