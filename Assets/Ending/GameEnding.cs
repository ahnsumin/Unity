using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    GameObject ending;
    public static string menu;

    void Start()
    {
        this.ending = GameObject.Find("ending");

        if(RabbitController.sceneNum == 1)
        {
            menu = "���";
        }
        else if(RabbitController.sceneNum == 2 )
        {
            menu = "���";
        }
        else if (RabbitController.sceneNum == 3)
        {
            menu = "���";
        }
        else if (RabbitController.sceneNum == 4)
        {
            menu = "����";
        }
        else if (RabbitController.sceneNum == 5)
        {
            menu = "����";
        }
        else if (RabbitController.sceneNum == 6)
        {
            menu = "����";
        }
        Debug.Log(menu);
    }

    void Update()
    {
        this.ending.GetComponent<Text>().text = menu + "�� ���߽��ϴ�. \n -���͸� �Է��ϸ� �Ѿ�ϴ�.-";

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("MainScene");
            DontDestroyOnLoad(GameObject.Find("MainTime"));

            if (SceneManager.GetActiveScene().name == "MainScene")
            {
                Destroy(GameObject.Find("Maintime"));
            }
        }
    }
}
