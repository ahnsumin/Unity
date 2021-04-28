using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomStart : MonoBehaviour
{
    public void OnClickLoad()
    {
        SceneManager.LoadScene("RandomScene");
        DontDestroyOnLoad(GameObject.Find("MainTime"));

        if (SceneManager.GetActiveScene().name == "RandomScene")
        {
            Destroy(GameObject.Find("Maintime"));
        }
    }
}
