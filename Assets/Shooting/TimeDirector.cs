using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeDirector : MonoBehaviour
{
    public float LimitTime;
    public string egg;
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
        this.timer.GetComponent<Text>().text = "�����ð�: " + LimitTime.ToString("F0") + "��";

        GameObject director = GameObject.Find("ArrowCountDirector");
        bool filled = director.GetComponent<ArrowCountDirector>().IsFilled();

        if (LimitTime <= 0 && filled == false)
        {
            SceneManager.LoadScene("GameOver");
            Destroy(gameObject);
            DontDestroyOnLoad(GameObject.Find("MainTime"));

            if (SceneManager.GetActiveScene().name == "GameOver")
            {
                Destroy(GameObject.Find("Maintime"));
            }
        } else if(LimitTime > 0 && filled == true)
        {
            this.egg = "���";
            RabbitController.sceneNum = 2;
            Debug.Log(this.egg);
            SceneManager.LoadScene("GameEnding");
            DontDestroyOnLoad(GameObject.Find("MainTime"));

            if (SceneManager.GetActiveScene().name == "GameEnding")
            {
                Destroy(GameObject.Find("Maintime"));
            }
        }
    }
}
