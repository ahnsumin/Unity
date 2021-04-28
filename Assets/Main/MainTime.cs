using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainTime : MonoBehaviour
{
    public float limitTime = 0;
    bool timeover;

    // Start is called before the first frame update
    void Start()
    {
        this.timeover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.limitTime < 0 && this.timeover == false)
        {
            this.timeover = true;
            SceneManager.LoadScene("Ending");
            DontDestroyOnLoad(GameObject.Find("MainTime"));

            if (SceneManager.GetActiveScene().name == "Ending")
            {
                Destroy(GameObject.Find("Maintime"));
            }
        } else
        {
            this.limitTime -= Time.deltaTime;
        }
    }
}
