using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberDirector : MonoBehaviour
{
    GameObject number;
    GameObject countText;
    int randNum;
    int thinkNum;
    int count;
    bool isCount;
    bool isCorrect;
    bool isWrong;

    // Start is called before the first frame update
    void Start()
    {
        this.randNum = Random.Range(1, 50);
        this.number = GameObject.Find("Number");
        this.countText = GameObject.Find("Count");
        this.count = 7;
        this.isCount = false;
        this.isCorrect = false;
        this.isWrong = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("InputDirector").GetComponent<InputDirector>() == null){
            this.thinkNum = 0;
        } else
        {
            if (this.thinkNum != GameObject.Find("InputDirector").GetComponent<InputDirector>().number)
            {
                this.isCount = false;
            }
            this.thinkNum = GameObject.Find("InputDirector").GetComponent<InputDirector>().number;
        }

        if(this.count <= 7 && this.count > 0 && this.isCount == false)
        {
            if (this.thinkNum == 0)
            {
                this.number.GetComponent<Text>().text = "?";
                this.countText.GetComponent<Text>().text = "���� Ƚ���� " + this.count.ToString("F0") + "ȸ �Դϴ�.";
            }
            else if (this.randNum > this.thinkNum)
            {
                this.number.GetComponent<Text>().text = "up";
                this.count--;
                this.countText.GetComponent<Text>().text = "���� Ƚ���� " + this.count.ToString("F0") + "ȸ �Դϴ�.";
                this.isCount = true;
            }
            else if (this.randNum < this.thinkNum)
            {
                this.number.GetComponent<Text>().text = "Down";
                this.count--;
                this.countText.GetComponent<Text>().text = "���� Ƚ���� " + this.count.ToString("F0") + "ȸ �Դϴ� .";
                this.isCount = true;
            }
            else if (this.randNum == this.thinkNum)
            {
                this.number.GetComponent<Text>().text = "����";
                this.count--;
                this.countText.GetComponent<Text>().text = "ȭ���� ���콺 ���� ��ư���� Ŭ���ϸ� �Ѿ�ϴ�.";
                this.isCount = true;
                this.isCorrect = true;
            }
        } else if(count == 0 && this.isCount == true)
        {
            this.number.GetComponent<Text>().text = "���ڴ� " + this.randNum.ToString("F0") + "�Դϴ�.";
            this.countText.GetComponent<Text>().text = "ȭ���� ���콺 ���� ��ư���� Ŭ���ϸ� �Ѿ�ϴ�.";
            this.isWrong = true;
        }

        if(this.isCorrect == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("���� ȭ��");
                SceneManager.LoadScene("GameEnding");
            }
        }
        else if(this.isWrong == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
