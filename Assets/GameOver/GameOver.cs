using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    GameObject gameover;
    void Start()
    {
        this.gameover = GameObject.Find("Gameover");
    }

    void Update()
    {
        this.gameover.GetComponent<Text>().text = "GAMEOVER \n 엔터를 누르면 이동합니다.";

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
