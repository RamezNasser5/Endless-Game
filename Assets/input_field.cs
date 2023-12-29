using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputField : MonoBehaviour
{
    public TMP_InputField tMP_InputField;
    // Start is called before the first frame update
    public void OnButtonCleck() {
        if (tMP_InputField.text != "")
        {
            Moveorb.userName = tMP_InputField.text;
        }
        SceneManager.LoadScene("level1");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
