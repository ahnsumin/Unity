using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
   public void OnClickLoad()
    {
        SceneManager.LoadScene("MainScene");
    }
}
