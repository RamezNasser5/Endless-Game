
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
            GetComponent<TextMeshPro>().text = "Coins : " + GM.totalCoins;
        }
        if (gameObject.name == "Time")
        {
            GetComponent<TextMeshPro>().text = "Time : " + GM.totalTime;
        }
        if (gameObject.name == "RunStatus")
        {
            GetComponent<TextMeshPro>().text = GM.lvlCompStatus;
        }
        
        
    }
}
