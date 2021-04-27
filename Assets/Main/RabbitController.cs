using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RabbitController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float walkForce = 30.0f;
    float maxWalkSpeed = 5.0f;
    bool counter = false;
    bool carrotScene = false;
    bool eggScene = false;
    bool meatScene = false;
    bool photatoScene = false;
    bool onionScene = false;
    bool chiliScene = false;
    GameObject roulette;
    string[] shop = new string[3];

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.roulette = GameObject.Find("roulette");
        for (int i = 0; i < this.shop.Length; i++)
        {
            this.shop[i] = this.roulette.GetComponent<RouletteController>().shop[i];
            Debug.Log(this.shop[i]);
        }
        Destroy(this.roulette);
    }

    // Update is called once per frame
    void Update()
    {
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        if(speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        if(transform.position.x < -13)
        {
            transform.position = new Vector3(-5, -3, 0);
            key = 0;
        }

        if (transform.position.x > 55)
        {
            transform.position = new Vector3(50, -3, 0);
            key = 0;
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key * 0.26058f, 0.26058f, 1);
        }

        if (Input.GetKeyDown(KeyCode.Return) && this.counter == true)
        {
            SceneManager.LoadScene("CounterScene");
        } else if (Input.GetKeyDown(KeyCode.Return) && this.carrotScene == true)
        {
            SceneManager.LoadScene("BottleOpening");
        } else if(Input.GetKeyDown(KeyCode.Return) && this.eggScene == true)
        {
            SceneManager.LoadScene("ShootingOpening");
        } else if (Input.GetKeyDown(KeyCode.Return) && this.meatScene == true)
        {
            SceneManager.LoadScene("RandomOpening");
        } else if (Input.GetKeyDown(KeyCode.Return) && this.photatoScene == true)
        {
            SceneManager.LoadScene("RunningOpening");
        } else if (Input.GetKeyDown(KeyCode.Return) && this.onionScene == true)
        {
            SceneManager.LoadScene("RoadOpening");
        } else if (Input.GetKeyDown(KeyCode.Return) && this.chiliScene == true)
        {
            SceneManager.LoadScene("UpDownOpening");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "counter")
        {
            Debug.Log("계산");
            this.counter = true;
            this.carrotScene = false;
            this.eggScene = false;
            this.meatScene = false;
            this.photatoScene = false;
            this.onionScene = false;
            this.chiliScene = false;
        } else if (other.gameObject.tag == "carrot")
        {
            Debug.Log("당근");
            this.counter = false;
            this.carrotScene = true;
            this.eggScene = false;
            this.meatScene = false;
            this.photatoScene = false;
            this.onionScene = false;
            this.chiliScene = false;
        } else if(other.gameObject.tag == "egg")
        {
            Debug.Log("계란");
            this.counter = false;
            this.carrotScene = false;
            this.eggScene = true;
            this.meatScene = false;
            this.photatoScene = false;
            this.onionScene = false;
            this.chiliScene = false;
        } else if (other.gameObject.tag == "meat")
        {
            Debug.Log("고기");
            this.counter = false;
            this.carrotScene = false;
            this.eggScene = false;
            this.meatScene = true;
            this.photatoScene = false;
            this.onionScene = false;
            this.chiliScene = false;
        } else if (other.gameObject.tag == "photato")
        {
            Debug.Log("감자");
            this.counter = false;
            this.carrotScene = false;
            this.eggScene = false;
            this.meatScene = false;
            this.photatoScene = true;
            this.onionScene = false;
            this.chiliScene = false;
        } else if (other.gameObject.tag == "onion")
        {
            Debug.Log("양파");
            this.counter = false;
            this.carrotScene = false;
            this.eggScene = false;
            this.meatScene = false;
            this.photatoScene = false;
            this.onionScene = true;
            this.chiliScene = false;
        } else if(other.gameObject.tag == "chili"){
            Debug.Log("고추");
            this.counter = false;
            this.carrotScene = false;
            this.eggScene = false;
            this.meatScene = false;
            this.photatoScene = false;
            this.onionScene = false;
            this.chiliScene = true;
        }
    }
}
