using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;
    float degree = 0;
    bool stop;
    bool first;
    bool change;
    public string[] shop = new string[3];
    public int count = 0;
    int number = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.stop = false;
        this.first = false;
        this.change = false;
        this.count = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //클릭하면 회전속도를 설정한다.
        if (Input.GetMouseButton(0))
        {
            this.rotSpeed = 10;
            this.first = true;
        } else
        {
            //속도를 줄여 멈추는 것 처럼 보이게 만듦
            this.rotSpeed *= 0.96f;
        }

        //회전을 시킨다
        transform.Rotate(0, 0, this.rotSpeed);
        
        //멈췄을 때 (멈춘 것 처럼 보였을 때) 각도 받아오기
        if (this.first == true && this.rotSpeed < 0.01)
        {
            this.degree = transform.rotation.eulerAngles.z;
            this.stop = true;
        }

        //멈췄을 때 각도에 맞춰 출력
        if (this.stop == true)
        {
            if (this.degree >= 0 && this.degree < 30 || this.degree >= 330 && this.degree < 360)
            {
                Debug.Log("당근");
                this.stop = false;
                this.first = false;
                this.shop[number] = "당근";
                this.number++;
                this.count--;
                if(this.count == 0)
                {
                    this.change = true;
                }
            }
            else if (this.degree >= 30 && this.degree < 90)
            {
                Debug.Log("고기");
                this.stop = false;
                this.first = false;
                this.shop[number] = "고기";
                this.number++;
                this.count--;
                if (this.count == 0)
                {
                    this.change = true;
                }
            }
            else if (this.degree >= 90 && this.degree < 150)
            {
                Debug.Log("감자");
                this.stop = false;
                this.first = false;
                this.shop[number] = "감자";
                this.number++;
                this.count--;
                if (this.count == 0)
                {
                    this.change = true;
                }
            }
            else if (this.degree >= 150 && this.degree < 210)
            {
                Debug.Log("계란");
                this.stop = false;
                this.first = false;
                this.shop[number] = "계란";
                this.number++;
                this.count--;
                if (this.count == 0)
                {
                    this.change = true;
                }
            }
            else if (this.degree >= 210 && this.degree < 270)
            {
                Debug.Log("양파");
                this.stop = false;
                this.first = false;
                this.shop[number] = "양파";
                this.number++;
                this.count--;
                if (this.count == 0)
                {
                    this.change = true;
                }
            }
            else if (this.degree >= 270 && this.degree < 330)
            {
                Debug.Log("고추");
                this.stop = false;
                this.first = false;
                this.shop[number] = "고추";
                this.number++;
                this.count--;
                if (this.count == 0)
                {
                    this.change = true;
                }
            }
        }

        if(this.change == true)
        {
            SceneManager.LoadScene("MainScene");
            DontDestroyOnLoad(gameObject);
        }
    }
}
