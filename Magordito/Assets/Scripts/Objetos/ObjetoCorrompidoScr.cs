using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoCorrompidoScr : MonoBehaviour
{
    private GameStateScr gs;
    private void Start()
    {
        gs = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameStateScr>();
    }
    
    public void OnClick()
    {
        Debug.Log("Lo has encontrado");
        gs.addPoint();
    }
    
}
