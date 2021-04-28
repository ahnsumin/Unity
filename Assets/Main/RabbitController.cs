using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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

    public static int sceneNum;

    public static bool isTiger;

    public static string[] shop = new string[3];
    public static ArrayList market = new ArrayList();

    // Start is called before the first frame update
    void Start()
    {
        sceneNum = 0;
        this.rigid2D = GetComponent<Rigidbody2D>();
        if (shop[0] == null)
        {
            this.roulette = GameObject.Find("roulette");
            for (int i = 0; i < shop.Length; i++)
            {
                shop[i] = this.roulette.GetComponent<RouletteController>().shop[i];
                Debug.Log(shop[i]);
            }
            Destroy(this.roulette);
        } else
        {
            Market();
        }
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

        if (GameObject.Find("MainTime").GetComponent<MainTime>().limitTime > 0 
            && GameObject.Find("MainTime").GetComponent<MainTime>().limitTime < 100
            && isTiger == false)
        {
            SceneManager.LoadScene("TigerScene");
            DontDestroyOnLoad(GameObject.Find("MainTime"));

            if (SceneManager.GetActiveScene().name == "TigerScene")
            {
                Destroy(GameObject.Find("Maintime"));
            }
        }

        MoveScene();
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

    void Market()
    {
        if(GameEnding.menu != null)
        {
            if (GameEnding.menu == "당근")
            {
                market.Add("당근");
                GameEnding.menu = null;
                Debug.Log("장바구니");
            }
            else if (GameEnding.menu == "계란")
            {
                market.Add("계란");
                GameEnding.menu = null;
                Debug.Log("장바구니");
            }
            else if (GameEnding.menu == "고기")
            {
                market.Add("고기");
                GameEnding.menu = null;
                Debug.Log("장바구니");
            }
            else if (GameEnding.menu == "감자")
            {
                market.Add("감자");
                GameEnding.menu = null;
                Debug.Log("장바구니");
            }
            else if (GameEnding.menu == "양파")
            {
                market.Add("양파");
                GameEnding.menu = null;
                Debug.Log("장바구니");
            }
            else if (GameEnding.menu == "고추")
            {
                market.Add("고추");
                GameEnding.menu = null;
                Debug.Log("장바구니");
            }
        }
    }

    void MoveScene()
    {
        if (Input.GetKeyDown(KeyCode.Return) && this.counter == true)
        {
            SceneManager.LoadScene("CounterScene");
            DontDestroyOnLoad(GameObject.Find("MainTime"));

            if (SceneManager.GetActiveScene().name == "CounterScene")
            {
                Destroy(GameObject.Find("Maintime"));
            }
        }
        else if (Input.GetKeyDown(KeyCode.Return) && this.carrotScene == true)
        {
            SceneManager.LoadScene("BottleOpening");
            DontDestroyOnLoad(GameObject.Find("MainTime"));

            if (SceneManager.GetActiveScene().name == "BottleOpening")
            {
                Destroy(GameObject.Find("Maintime"));
            }
        }
        else if (Input.GetKeyDown(KeyCode.Return) && this.eggScene == true)
        {
            SceneManager.LoadScene("ShootingOpening");
            DontDestroyOnLoad(GameObject.Find("MainTime"));

            if (SceneManager.GetActiveScene().name == "ShootingOpening")
            {
                Destroy(GameObject.Find("Maintime"));
            }
        }
        else if (Input.GetKeyDown(KeyCode.Return) && this.meatScene == true)
        {
            SceneManager.LoadScene("RandomOpening");
            DontDestroyOnLoad(GameObject.Find("MainTime"));

            if (SceneManager.GetActiveScene().name == "RandomOpening")
            {
                Destroy(GameObject.Find("Maintime"));
            }
        }
        else if (Input.GetKeyDown(KeyCode.Return) && this.photatoScene == true)
        {
            SceneManager.LoadScene("RunningOpening");
            DontDestroyOnLoad(GameObject.Find("MainTime"));

            if (SceneManager.GetActiveScene().name == "RunningOpening")
            {
                Destroy(GameObject.Find("Maintime"));
            }
        }
        else if (Input.GetKeyDown(KeyCode.Return) && this.onionScene == true)
        {
            SceneManager.LoadScene("RoadOpening");
            DontDestroyOnLoad(GameObject.Find("MainTime"));

            if (SceneManager.GetActiveScene().name == "RoadOpening")
            {
                Destroy(GameObject.Find("Maintime"));
            }
        }
        else if (Input.GetKeyDown(KeyCode.Return) && this.chiliScene == true)
        {
            SceneManager.LoadScene("UpDownOpening");
            DontDestroyOnLoad(GameObject.Find("MainTime"));

            if (SceneManager.GetActiveScene().name == "UpDownOpening")
            {
                Destroy(GameObject.Find("Maintime"));
            }
        }
    }
}
