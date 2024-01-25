using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject optionMenu;
    public GameObject playButton;
    bool isOpen;
    // Start is called before the first frame update
    void Start()
    {
        isOpen = false;
    }
    void OnMouseDown()
    {
        transform.localScale = new Vector3(0.9f, 0.9f, 1);
    }

    void OnMouseUp()
    {
        transform.localScale = new Vector3(1, 1, 1);
        if (isOpen == false)
        {
            optionMenu.SetActive(true);
            playButton.SetActive(false);
            isOpen = true;
        }
        else
        {
            optionMenu.SetActive(false);
            playButton.SetActive(true);
            isOpen = false;
        }
    }
    
    public void SetFullscreen(bool IsFullscreen)
    {
        Screen.fullScreen = IsFullscreen;
    }
}
    