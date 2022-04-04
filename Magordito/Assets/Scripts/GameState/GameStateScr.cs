using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateScr : MonoBehaviour
{
    public int nPlayers;
    public int[] vidasPlayers;
    public int[] puntosPlayers;

    [Header("Constantes")]
    public int vidasMax;
    private void Start()
    {
        vidasPlayers = new int[nPlayers];
        puntosPlayers = new int[nPlayers];

        for (int i = 0; i < nPlayers; i++)
        {
            vidasPlayers[i] = vidasMax;
            puntosPlayers[i] = 0;
        }
    }
}
