using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayTimeDirector : MonoBehaviour
{
    public float LimitTime = 0;
    GameObject playtime;
    // Start is called before the first frame update
    void Start()
    {
        this.playtime = GameObject.Find("Time");
    }

    // Update is called once per frame
    void Update()
    {
        this.playtime.GetComponent<Text>().text = "���� �ð�: " + this.LimitTime.ToString("F0") + "��";

        if(this.LimitTime <= 0)
        {
            Debug.Log("�ð��ʰ�");
        } else
        {
            this.LimitTime -= Time.deltaTime;
        }
    }
}
