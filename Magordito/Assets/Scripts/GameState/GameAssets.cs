using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    [Header("Objetos Corruptos")]
    public GameObject[] objetosCorruptos; //General
    public GameObject CalabazaC;
    public GameObject CalderoC;
    public GameObject MesaC;
    public GameObject PlantaC;
    public GameObject TelefonoC;
    public GameObject SofaC;
    public GameObject PercheroC;
    public GameObject MesitaC;
    public GameObject CofreC;

    [Header("Objetos Normales")]
    public GameObject[] objetosNormales; //General
    public GameObject CalabazaN;
    public GameObject CalderoN;
    public GameObject MesaN;
    public GameObject PlantaN;
    public GameObject TelefonoN;
    public GameObject SofaN;
    public GameObject PercheroN;
    public GameObject MesitaN;
    public GameObject CofreN;
    private void Awake()
    {
        objetosCorruptos = new GameObject[8];
        objetosCorruptos[0] = CalabazaC;
        objetosCorruptos[1] = CalderoC;
        objetosCorruptos[2] = MesaC;
        objetosCorruptos[3] = PlantaC;
        objetosCorruptos[4] = TelefonoC;
        objetosCorruptos[5] = PercheroC;
        objetosCorruptos[6] = MesitaC;
        objetosCorruptos[7] = CofreC;
        objetosNormales = new GameObject[8];
        objetosNormales[0] = CalabazaN;
        objetosNormales[1] = CalderoN;
        objetosNormales[2] = MesaN;
        objetosNormales[3] = PlantaN;
        objetosNormales[4] = TelefonoN;
        objetosNormales[5] = PercheroN;
        objetosNormales[6] = MesitaN;
        objetosNormales[7] = CofreN;
    }
}
