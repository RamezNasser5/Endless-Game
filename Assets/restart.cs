using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void Pause()
    {
       
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

   public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

   
    public void Restart()
    {
       Moveorb.totalCoins=0;
       Moveorb.totalTime =0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
      
    }
}
