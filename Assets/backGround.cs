using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
        private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
        // Check if audio source and clip are assigned
        if (audioSource != null && audioSource.clip != null)
        {
            // Play the background music
            audioSource.Play();
        }
        else
        {
            Debug.LogError("Background music audio source or clip is not assigned.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
