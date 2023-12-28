
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "Coins")
        {
            // if (Moveorb.totalScore < Moveorb.totalCoins)
            // {
            //     Moveorb.totalScore = Moveorb.totalCoins;
            // }
            GetComponent<TextMeshPro>().text = "score : " + Moveorb.totalCoins;
        }
        if (gameObject.name == "Time")
        {
            GetComponent<TextMeshPro>().text = "Time : " + Moveorb.roundedTime;
        }
        if (gameObject.name == "RunStatus")
        {
            GetComponent<TextMeshPro>().text = GM.lvlCompStatus;
        }
        
        
    }
}
