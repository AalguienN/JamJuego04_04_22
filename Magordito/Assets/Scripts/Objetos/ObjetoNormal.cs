using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoNormal : MonoBehaviour
{
    private GameStateScr gs;
    private void Start()
    {
        gs = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameStateScr>();
    }
    // Cuando el enemigo
   
    public void OnClick()
    {
        Debug.Log("Te has equivocado");
        gs.damagePlayer();
    }
}
