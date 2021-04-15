using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowCountDirector : MonoBehaviour
{
    GameObject arrowCount;

    // Start is called before the first frame update
    void Start()
    {
        this.arrowCount = GameObject.Find("arrowCount");
        this.arrowCount.GetComponent<Image>().fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseCount()
    {
        this.arrowCount.GetComponent<Image>().fillAmount += 0.1f;
    }

    public bool IsFilled()
    {
        if(this.arrowCount.GetComponent<Image>().fillAmount >= 1.0f)
        {
            return true;
        } else
        {
            return false;
        }
    }
}
