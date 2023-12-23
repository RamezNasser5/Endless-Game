using UnityEngine;

public class Effacts : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "Capsule(Clone)")
        {
            transform.Rotate(3,0,0);    
        }
        if (gameObject.name == "Coins(Clone)")
        {
            transform.Rotate(0,0,3);
        }
        
    }
}
