using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    internal new static MenuManager instance;

    private bool isGamePaused = false;
    
    //Menus
    //[SerializeField] private GameObject gameOver;
    //[SerializeField] private GameObject win;
    [SerializeField] private GameObject pause;

    [SerializeField] private KeyCode onPause = KeyCode.Escape;

    private void Awake()
    {
        if (instance != null)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            instance = this;
        }
        
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
        pause.SetActive(false);
    }

    private void Start()
    {
        //UiAnimPause.instance.CloseMenu();
    }

    private void Update()
    {
        PauseMenu();
        
        /*if (isGamePaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }*/
    }

    public void PauseMenu()
    {
        if (Input.GetKeyDown(onPause))
        {
            Time.timeScale = 0;
            pause.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            //UiAnimPause.instance.OpenMenu();
        }
    }

    public void Resume()
    {
        Time.timeScale = 1;
        isGamePaused = false;
        pause.SetActive(false);
        //UiAnimPause.instance.CloseMenu();
    }
    
    public void ReloadLevel()
    {
        Time.timeScale = 1;
        //UiAnimGameOver.instance.CloseMenu();
        pause.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void BackToMenu()
    {
        Time.timeScale = 1;
        //SceneManager.LoadScene(0);
    }
}
