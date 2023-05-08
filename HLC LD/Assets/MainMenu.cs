using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject settingsMenu;
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Confined;
        settingsMenu.SetActive(false);
        Cursor.visible = true;
    }
    
    public void LoadGame(string level)
    {
        SceneManager.LoadScene(level);
    }
    
    public void OptionsMenu()
    {
        settingsMenu.SetActive(true);
    }

    public void BackFromSettings()
    {
        settingsMenu.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
