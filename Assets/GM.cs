using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public static float vertVel = 0;
    public static int totalCoins = 0;
    public static float totalTime = 0;
    public static float zVelAdj = 1;
    public static string lvlCompStatus = "";
    public  Transform BlockMidPit;
    public  Transform BlockNoPit;
    public  Transform coinsObj;
    public  Transform obsObj;
    public  Transform capsuleObj;
    public int randomNum;

    public float waitToLoad = 0;
    public float zScenePos = 58;
    // Start is called before the first frame update
    void Start()
    {

        Instantiate(BlockMidPit.gameObject, new Vector3(0, 2.17f, 42), BlockMidPit.rotation);
        Instantiate(BlockMidPit.gameObject, new Vector3(0, 2.17f, 46), BlockMidPit.rotation);

        Instantiate(BlockNoPit.gameObject, new Vector3(0, 2.17f, 42), BlockNoPit.rotation);
        Instantiate(BlockNoPit.gameObject, new Vector3(0, 2.17f, 46), BlockNoPit.rotation);


    }

    // Update is called once per frame
    void Update()
    {
        if (zScenePos < 120)
        {
            randomNum = Random.Range(0,10);
            if (randomNum < 3)
            {
                Instantiate(coinsObj,new Vector3(-1, 3.17f, zScenePos),coinsObj.rotation);
            }
            if (randomNum < 3)
            {
                Instantiate(coinsObj,new Vector3(1, 3.17f, zScenePos),coinsObj.rotation);
            }
            if (randomNum == 4)
            {
                Instantiate(obsObj,new Vector3(1, 3.17f, zScenePos),obsObj.rotation);
            }
            if (randomNum == 5)
            {
                Instantiate(obsObj,new Vector3(0, 3.17f, zScenePos),obsObj.rotation);
            }
            Instantiate(BlockNoPit.gameObject, new Vector3(0, 2.17f, zScenePos), BlockNoPit.rotation);
            zScenePos += 4;
        }
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
