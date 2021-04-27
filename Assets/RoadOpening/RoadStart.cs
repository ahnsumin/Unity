using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoadStart : MonoBehaviour
{
    public void OnClickLoad()
    {
        SceneManager.LoadScene("RoadScene");
    }
}
