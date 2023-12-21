using UnityEngine;

public class Movecam : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody> ().velocity = new Vector3 (0,GM.vertVel,4*GM.zVelAdj);
    }
}
