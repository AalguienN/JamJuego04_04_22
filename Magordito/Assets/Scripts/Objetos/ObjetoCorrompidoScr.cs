using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoCorrompidoScr : MonoBehaviour
{
    private GameStateScr gs;
    public GameObject fantasma;
    private void Start()
    {
        gs = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameStateScr>();
    }
    
    public void OnClick()
    {
        Debug.Log("Lo has encontrado");
        
        Instantiate(fantasma, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
    
}
