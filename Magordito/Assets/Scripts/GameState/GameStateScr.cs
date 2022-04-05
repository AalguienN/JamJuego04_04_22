using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameStateScr : MonoBehaviour
{
    private int vidasPlayer;
    private int puntosPlayer;
    public int highscore;
    public Text text;
    public bool enpausa=false;
    private bool ensettings = false;
    public GameObject pausaa;
    public GameObject settingss;
    public GameObject panel;

    [Header("Constantes")]
    public int vidasMax;
    public int pointsToWin;
    private void Start()
    {
        vidasPlayer = vidasMax;
        puntosPlayer = 0+ PlayerPrefs.GetInt("LastScore"); ;
    }
    private void PlayerDead() { 
    
    }
    
    public void damagePlayer() {
        vidasPlayer--;
        if (vidasPlayer <= 0) PlayerDead();
    }
    public void addPoint() {
        puntosPlayer++;
    }
    public int getVidaPlayer() {
        return vidasPlayer;
    }
    public int getPoints() { return puntosPlayer; }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausa();
        }
        PlayerPrefs.GetInt("highscore", highscore);
        if (puntosPlayer > highscore)
        {

            highscore = puntosPlayer;
            

            PlayerPrefs.SetInt("highscore", highscore);
        }
        text.text = "" + puntosPlayer;

    }
    public void pausa()
    {
        if (enpausa)
        {
            Time.timeScale = 1;
            pausaa.SetActive(false);
            enpausa = false;
            
            

        }
        else
        {
            pausaa.SetActive(true);
            enpausa = true;
            Time.timeScale = 0;
        }
    }
    public void loadMenu()
    {
        if (puntosPlayer > highscore)
        {

            highscore = puntosPlayer;


            PlayerPrefs.SetInt("highscore", highscore);
        }
        Time.timeScale = 1;
        SceneManager.UnloadScene(1);
        SceneManager.LoadScene(0);
        
    }
    public void settings()
    {
        if (ensettings)
        {
            panel.SetActive(true);
            settingss.SetActive(false);
            ensettings = false;



        }
        else
        {
            panel.SetActive(false);
            settingss.SetActive(true);
            ensettings = true;
        }
    }
}
