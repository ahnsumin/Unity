using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootingStart : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClickLoad()
    {
        SceneManager.LoadScene("ShootinScene");
    }
}
