using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDirector : MonoBehaviour
{
    public float LimitTime;
    GameObject timer;
    
    // Start is called before the first frame update
    void Start()
    {
        this.timer = GameObject.Find("Time");
    }

    // Update is called once per frame
    void Update()
    {
        this.LimitTime -= Time.deltaTime;
        this.timer.GetComponent<Text>().text = "남은시간: " + LimitTime.ToString("F0") + "초";

        GameObject director = GameObject.Find("ArrowCountDirector");
        bool filled = director.GetComponent<ArrowCountDirector>().IsFilled();

        if (LimitTime <= 0 && filled == false)
        {
            Debug.Log("게임오버");
        } else if(LimitTime > 0 && filled == true)
        {
            Debug.Log("게임성공");
        }
    }
}
