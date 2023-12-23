using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public static float vertVel = 0;
    public static int totalCoins = 0;
    public static float totalTime = 0;
    public static float zVelAdj = 1;
    public static string lvlCompStatus = "";
    public Transform BlockMidPit;
    public Transform BlockNoPit;
    public float waitToLoad = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (BlockNoPit != null)
        {
            Instantiate(BlockNoPit.gameObject, new Vector3(0, 2.17f, 42), BlockNoPit.rotation);
            Instantiate(BlockNoPit.gameObject, new Vector3(0, 2.17f, 46), BlockNoPit.rotation);
        }

    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(BlockMidPit.gameObject, new Vector3(0, 2.17f, 50), BlockMidPit.rotation);
        Instantiate(BlockMidPit.gameObject, new Vector3(0, 2.17f, 54), BlockMidPit.rotation);

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
