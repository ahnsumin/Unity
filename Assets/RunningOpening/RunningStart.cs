using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunningStart : MonoBehaviour
{
    public void OnClickLoad()
    {
        SceneManager.LoadScene("RunningScene");
    }
}
