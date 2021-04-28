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
            menu = "당근";
        }
        else if(RabbitController.sceneNum == 2 )
        {
            menu = "계란";
        }
        else if (RabbitController.sceneNum == 3)
        {
            menu = "고기";
        }
        else if (RabbitController.sceneNum == 4)
        {
            menu = "감자";
        }
        else if (RabbitController.sceneNum == 5)
        {
            menu = "양파";
        }
        else if (RabbitController.sceneNum == 6)
        {
            menu = "고추";
        }
        Debug.Log(menu);
    }

    void Update()
    {
        this.ending.GetComponent<Text>().text = menu + "를 구했습니다. \n -엔터를 입력하면 넘어갑니다.-";

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
