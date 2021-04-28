using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlueCarController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.045f, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Lose");
        Destroy(gameObject);
        SceneManager.LoadScene("GameOver");
        DontDestroyOnLoad(GameObject.Find("MainTime"));

        if (SceneManager.GetActiveScene().name == "GameOver")
        {
            Destroy(GameObject.Find("Maintime"));
        }
    }
}
