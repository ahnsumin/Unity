using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottleStart : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClickLoad()
    {
        SceneManager.LoadScene("BottleScene");
        DontDestroyOnLoad(GameObject.Find("MainTime"));

        if (SceneManager.GetActiveScene().name == "BottleScene")
        {
            Destroy(GameObject.Find("Maintime"));
        }
    }
}
