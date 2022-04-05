using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menú : MonoBehaviour
{
    private bool settingsen;
    public GameObject settingsC;
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadScene()
    {
        SceneManager.UnloadScene(0);
        SceneManager.LoadScene(1);
        
    }
    public void settings()
    {
        if(settingsen == true) {
            menu.SetActive(true);
            settingsC.SetActive(false);
            settingsen = false;
        }
        else {
            menu.SetActive(false);
            settingsC.SetActive(true);
            settingsen = true;
        }

    }
    public void close()
    {
        Application.Quit();
    }
}
