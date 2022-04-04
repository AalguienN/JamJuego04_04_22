using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateScr : MonoBehaviour
{
    public int nPlayers;
    public int[] vidasPlayers;
    public int[] puntosPlayers;
    private void Start()
    {
        vidasPlayers = new int[nPlayers];
       
        puntosPlayers = new int[nPlayers];
        
    }

}
