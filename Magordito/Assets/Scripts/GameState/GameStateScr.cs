using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateScr : MonoBehaviour
{
    private int vidasPlayer;
    private int puntosPlayer;

    [Header("Constantes")]
    public int vidasMax;
    public int pointsToWin;
    private void Start()
    {
        vidasPlayer = vidasMax;
        puntosPlayer = 0;
    }
    public void damagePlayer() {
        vidasPlayer--;
    }
    public void addPoint() {
        puntosPlayer++;
    }
    public int getVidaPlayer() {
        return vidasPlayer;
    }
    public int getPoints() { return puntosPlayer; }


}
