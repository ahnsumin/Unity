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
        //Ŭ���ϸ� ȸ���ӵ��� �����Ѵ�.
        if (Input.GetMouseButton(0))
        {
            this.rotSpeed = 10;
            this.first = true;
        } else
        {
            //�ӵ��� �ٿ� ���ߴ� �� ó�� ���̰� ����
            this.rotSpeed *= 0.96f;
        }

        //ȸ���� ��Ų��
        transform.Rotate(0, 0, this.rotSpeed);
        
        //������ �� (���� �� ó�� ������ ��) ���� �޾ƿ���
        if (this.first == true && this.rotSpeed < 0.01)
        {
            this.degree = transform.rotation.eulerAngles.z;
            this.stop = true;
        }

        //������ �� ������ ���� ���
        if (this.stop == true)
        {
            if (this.degree >= 0 && this.degree < 30 || this.degree >= 330 && this.degree < 360)
            {
                Debug.Log("���");
                this.stop = false;
                this.first = false;
                this.shop[number] = "���";
                this.number++;
                this.count--;
                if(this.count == 0)
                {
                    this.change = true;
                }
            }
            else if (this.degree >= 30 && this.degree < 90)
            {
                Debug.Log("���");
                this.stop = false;
                this.first = false;
                this.shop[number] = "���";
                this.number++;
                this.count--;
                if (this.count == 0)
                {
                    this.change = true;
                }
            }
            else if (this.degree >= 90 && this.degree < 150)
            {
                Debug.Log("����");
                this.stop = false;
                this.first = false;
                this.shop[number] = "����";
                this.number++;
                this.count--;
                if (this.count == 0)
                {
                    this.change = true;
                }
            }
            else if (this.degree >= 150 && this.degree < 210)
            {
                Debug.Log("���");
                this.stop = false;
                this.first = false;
                this.shop[number] = "���";
                this.number++;
                this.count--;
                if (this.count == 0)
                {
                    this.change = true;
                }
            }
            else if (this.degree >= 210 && this.degree < 270)
            {
                Debug.Log("����");
                this.stop = false;
                this.first = false;
                this.shop[number] = "����";
                this.number++;
                this.count--;
                if (this.count == 0)
                {
                    this.change = true;
                }
            }
            else if (this.degree >= 270 && this.degree < 330)
            {
                Debug.Log("����");
                this.stop = false;
                this.first = false;
                this.shop[number] = "����";
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
