using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputDirector : MonoBehaviour
{
    public int number = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InputNumber(InputField ip)
    {
        Debug.Log("�Է��� ������ " + ip.text + "�Դϴ�");
        string text = ip.text;
        this.number = int.Parse(text);
    }
}
