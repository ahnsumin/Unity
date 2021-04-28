using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterTimeDirector : MonoBehaviour
{
    float currentTime = 0;
    GameObject counterTimer;

    // Start is called before the first frame update
    void Start()
    {
        this.counterTimer = GameObject.Find("Time");
    }

    // Update is called once per frame
    void Update()
    {
        this.currentTime = GameObject.Find("MainTime").GetComponent<MainTime>().limitTime;
        this.counterTimer.GetComponent<Text>().text = "남은 시간은 " + this.currentTime.ToString("F1") + "입니다.";
    }
}
