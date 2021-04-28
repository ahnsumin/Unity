using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainTimerDirector : MonoBehaviour
{
    GameObject timer;
    float currentTimer;

    // Start is called before the first frame update
    void Start()
    {
        this.timer = GameObject.Find("Timer");
    }

    // Update is called once per frame
    void Update()
    {
        this.currentTimer = GameObject.Find("MainTime").GetComponent<MainTime>().limitTime;
        this.timer.GetComponent<Text>().text = "남은 시간은 " + this.currentTimer.ToString("F1") + "입니다.";
    }
}
