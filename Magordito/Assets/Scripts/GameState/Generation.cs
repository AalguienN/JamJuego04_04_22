using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour 
{
    public int numObj;
    private int numOC; //Numero de objetos corrompidos
    [Header("Referencias")]
    GameAssets ga;

    private int[] posCorr;
    public Vector3[] objPositions;
    private GameObject[] objetosCargados;

    [Header("Posiciones especiales")]
    public Vector3 sofaPos;

    // Start is called before the first frame update
    void Start()
    {
        numOC = GetComponent<GameStateScr>().pointsToWin;
        ga = gameObject.GetComponent<GameAssets>();
        if (rand(2))
        {
            Instantiate(ga.SofaC, sofaPos, new Quaternion(0, 0, 0, 0));
            numOC--;
        }
        else
        {
            Instantiate(ga.SofaN, sofaPos, new Quaternion(0, 0, 0, 0));
        }
        Generate();
    }

    
    void Generate() {
        objetosCargados = new GameObject[objPositions.Length];
        for (int i = 0; i < objPositions.Length; i++) {
            if (Random.Range(0, 2) == 1 && numOC > 0 || i+numOC>=objPositions.Length)
            {
                Instantiate(gameObject.GetComponent<GameAssets>().objetosCorruptos[Random.Range(0, 5)], objPositions[i], new Quaternion(0, 0, 0, 0));
                numOC--;
            }
            else
            {
                Instantiate(gameObject.GetComponent<GameAssets>().objetosNormales[Random.Range(0, 5)], objPositions[i], new Quaternion(0, 0, 0, 0));
            }
        }
    }

    private bool rand(int max) { 
        return Random.Range(0, max) < 1;
    }

    





    
}
