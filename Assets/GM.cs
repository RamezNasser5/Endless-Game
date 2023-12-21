using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public static float vertVel = 0;
    public static int totalCoins = 0;
    public static float totalTime = 0;
    public static float zVelAdj = 1;
    public static string lvlCompStatus = "";
    public float waitToLoad = 0;
    // Start is called before the first frame update
    // void Start()
    // {

    // }

    // Update is called once per frame
    void Update()
    {
        totalTime += Time.deltaTime;
        if (lvlCompStatus == "Fail")
        {
            waitToLoad += Time.deltaTime;
        }
        if (waitToLoad > 2)
        {
            SceneManager.LoadScene("LevelComp");
        }
    }
}
