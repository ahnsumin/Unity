using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingDirector : MonoBehaviour
{
    GameObject endingRoulette;
    GameObject endingMarket;
    GameObject time;
    GameObject success;

    string menu;
    string market;
    float endingTime;

    string[] shop = new string[3];

    // Start is called before the first frame update
    void Start()
    {
        this.endingRoulette = GameObject.Find("EndingRoulette");
        this.endingMarket = GameObject.Find("EndingMarket");
        this.success = GameObject.Find("Success");
        this.time = GameObject.Find("MainTime");

        for(int i = 0; i < RabbitController.shop.Length; i++)
        {
            this.shop[i] = RabbitController.shop[i];
            this.menu += RabbitController.shop[i] + " ";
        }
        for(int i = 0; i < RabbitController.market.Count; i++)
        {
            this.market += RabbitController.market[i] + " ";
        }

        this.endingTime = this.time.GetComponent<MainTime>().limitTime;
    }

    // Update is called once per frame
    void Update()
    {
        int count = -1;

        this.endingRoulette.GetComponent<Text>().text = "봐야할 장은 " + this.menu + "입니다.";
        this.endingMarket.GetComponent<Text>().text = "봐 온 장은 " + this.market + "입니다.";

        if (this.endingTime <= 0)
        {
            this.success.GetComponent<Text>().text = "시간 초과!";
        }
        else if (TigerController.isDead == true)
        {
            this.success.GetComponent<Text>().text = "사망";
        }
        else if (RabbitController.market.Count > 0)
        {
            if (this.shop.Length != RabbitController.market.Count)
            {
                Debug.Log(shop.Length);
                Debug.Log(RabbitController.market.Count);
                this.success.GetComponent<Text>().text = "실패!";
            }
            else
            {
                for (int i = 0; i < this.shop.Length; i++)
                {
                    for (int j = 0; j < RabbitController.market.Count; j++)
                    {
                        if (this.shop[i] == RabbitController.market[j].ToString())
                        {
                            RabbitController.market.Remove(RabbitController.market[j]);
                            count = RabbitController.market.Count;
                            Debug.Log(count);
                        }
                    }
                }

                if (count == 0)
                {
                    this.success.GetComponent<Text>().text = "성공!";
                }
                else
                {
                    this.success.GetComponent<Text>().text = "실패!";
                }
            }
        }
    }
}
