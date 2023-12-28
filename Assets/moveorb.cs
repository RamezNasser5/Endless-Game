
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moveorb : MonoBehaviour
{
    public KeyCode moveL;
    public KeyCode moveR;
    public static int totalCoins = 0;
    public TextMeshPro coins;
    public static float totalTime = 0;
    public static float roundedTime = 0;
    public TextMeshPro time;
    //public static int totalScore = 0;
    //public TextMeshPro score;
    public float horizVel = 0;
    public int laneNum = 2;
    public string controlLocked = "n";
    public Transform boomObj;
    public AudioSource coinSound; // Add an AudioSource variable

    // Start is called before the first frame update
    void Start()
    {
        //coinSound = GetComponent<AudioSource>(); // Initialize AudioSource
        coins.text = $"coins : {0}";
        time.text = $"time : {0}";
        //score.text = $"score : {0}";
    }

    // Update is called once per frame
    void Update()
    {
        // Automatically move forward
        GetComponent<Rigidbody>().velocity = new Vector3(horizVel, GM.vertVel, 4);

        // Check for user input to steer left
        if (Input.GetKeyDown(moveL) && (laneNum > 1) && (controlLocked == "n"))
        {
            horizVel = -2;
            StartCoroutine(StopSlide());
            laneNum -= 1;
            controlLocked = "y";
        }

        // Check for user input to steer right
        if (Input.GetKeyDown(moveR) && (laneNum < 3) && (controlLocked == "n"))
        {
            horizVel = 2;
            StartCoroutine(StopSlide());
            laneNum += 1;
            controlLocked = "y";
        }
        totalTime += Time.deltaTime;
        roundedTime = Mathf.RoundToInt(totalTime);
        time.text = $"time : {roundedTime}";
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("lethal"))
        {
            Destroy(gameObject);
            GM.zVelAdj = 0;
            Instantiate(boomObj, transform.position, boomObj.rotation);
            GM.lvlCompStatus = "Fail";
        }
        if (other.gameObject.name == "Capsule(Clone)")
        {
            Destroy(other.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "rampbottomtrig")
        {
            GM.vertVel = 2;
        }
        if (other.gameObject.name == "ramptoptrig")
        {
            GM.vertVel = 0;
        }
        if (other.gameObject.name == "exit")
        {
            GM.lvlCompStatus = "Success!";
            SceneManager.LoadScene("LevelComp");
        }
        if (other.gameObject.name == "Coins(Clone)")
        {
            Destroy(other.gameObject);
            totalCoins++;
            coins.text = $"coins : {totalCoins}";
            //score.text = $"coins : {totalScore}";
            // Play the coin sound when the player collects a coin
            if (coinSound != null)
            {
                coinSound.Play();
            }
        }
    }

    IEnumerator StopSlide()
    {
        yield return new WaitForSeconds(.5f);
        horizVel = 0;
        controlLocked = "n";
    }
}

