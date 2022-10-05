using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoNormal : MonoBehaviour
{
    public GameObject objRoto;
    private GameStateScr gs;
    private void Start()
    {
        gs = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameStateScr>();
    }
    // Cuando el enemigo
   
    public void OnClick()
    {
        //Debug.Log("Te has equivocado");
        Instantiate(objRoto, transform.position, transform.rotation);
        gs.damagePlayer();
        Destroy(gameObject);
    }
}
