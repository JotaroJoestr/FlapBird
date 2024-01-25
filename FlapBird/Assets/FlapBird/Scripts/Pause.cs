using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    bool isPaused;
    public GameObject PauseUI, MainMenu;
    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                isPaused = false;
                MainMenu.SetActive(false);
                PauseUI.SetActive(false);
                Time.timeScale = 1f;
            }
            else
            {
                isPaused = true;
                MainMenu.SetActive(true);
                PauseUI.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }
}
