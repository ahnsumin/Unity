using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpDownStart : MonoBehaviour
{
    public void OnClickLoad()
    {
        SceneManager.LoadScene("UpDownScene");
    }
}
