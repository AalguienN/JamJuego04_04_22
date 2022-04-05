using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    [Header("Objetos Corruptos")]
    public GameObject[] objetosCorruptos;
    public GameObject CalabazaC;
    public GameObject CalderoC;
    public GameObject MesaC;
    public GameObject PlantaC;
    public GameObject TelefonoC;

    [Header("Objetos Normales")]
    public GameObject[] objetosNormales;
    public GameObject CalabazaN;
    public GameObject CalderoN;
    public GameObject MesaN;
    public GameObject PlantaN;
    public GameObject TelefonoN;
    private void Awake()
    {
        objetosCorruptos = new GameObject[5];
        objetosCorruptos[0] = CalabazaC;
        objetosCorruptos[1] = CalderoC;
        objetosCorruptos[2] = MesaC;
        objetosCorruptos[3] = PlantaC;
        objetosCorruptos[4] = TelefonoC;
    objetosNormales = new GameObject[5];
        objetosNormales[0] = CalabazaN;
        objetosNormales[1] = CalderoN;
        objetosNormales[2] = MesaN;
        objetosNormales[3] = PlantaN;
        objetosNormales[4] = TelefonoN;
    }
}
