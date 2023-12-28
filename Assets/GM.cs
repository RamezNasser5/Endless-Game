using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public static float vertVel = 0;
    
    
    public static float zVelAdj = 1;
    public static string lvlCompStatus = "";
    public Transform BlockMidPit;
    public Transform BlockNoPit;
    public Transform coinsObj;
    public Transform obsObj;
    public Transform capsuleObj;
    public int randomNum;

    public float waitToLoad = 0;
    public float zScenePos = 56;
    // Start is called before the first frame update
    void Start()
    {

        Instantiate(BlockMidPit, new Vector3(2, 6f, 40), BlockMidPit.rotation);
        Instantiate(BlockMidPit, new Vector3(2, 6f, 44), BlockMidPit.rotation);

        Instantiate(BlockNoPit, new Vector3(2, 6f, 48), BlockNoPit.rotation);
        Instantiate(BlockNoPit, new Vector3(2, 6f, 52), BlockNoPit.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        if (zScenePos < float.MaxValue)
        {
            randomNum = Random.Range(0, 36);
            if (randomNum >= 0 && randomNum <= 10)
            {
                Instantiate(coinsObj, new Vector3(-1, 4.17f, zScenePos), coinsObj.rotation);
            }
            if (randomNum >= 11 && randomNum <= 20)
            {
                Instantiate(coinsObj, new Vector3(0, 4.17f, zScenePos), coinsObj.rotation);
            }
            if (randomNum >= 21 && randomNum <= 30)
            {
                Instantiate(coinsObj, new Vector3(1, 4.17f, zScenePos), coinsObj.rotation);
            }
            if (randomNum >= 31 && randomNum <= 32)
            {
                Instantiate(obsObj, new Vector3(-1, 3.6f, zScenePos), obsObj.rotation);
            }
            if (randomNum >= 33 && randomNum <= 34)
            {
                Instantiate(obsObj, new Vector3(0, 3.6f, zScenePos), obsObj.rotation);
            }
            if (randomNum >= 35 && randomNum <= 36)
            {
                Instantiate(obsObj, new Vector3(1, 3.6f, zScenePos), obsObj.rotation);
            }
            Instantiate(BlockNoPit, new Vector3(2, 6f, zScenePos), BlockNoPit.rotation);
            zScenePos += 4;
        }
        
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
