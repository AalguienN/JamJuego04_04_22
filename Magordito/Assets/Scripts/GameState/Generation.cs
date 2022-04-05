using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour 
{
    public int numObj;
    private int numOC; //Numero de objetos corrompidos
    
    public Vector3[] objPositions;
    public GameObject[] objetosCargados;

    // Start is called before the first frame update
    void Start()
    {
        numOC = gameObject.GetComponent<GameStateScr>().pointsToWin;
        Generate();
    }

    
    void Generate() {
        objetosCargados = new GameObject[objPositions.Length];
        for (int i = 0; i < objPositions.Length; i++) {
            
            Instantiate(gameObject.GetComponent<GameAssets>().objetosNormales[Random.Range(0, 5)], objPositions[i], new Quaternion(0, 0, 0, 0));
        }    
    }
    





    
}
