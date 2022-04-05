using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Creditos : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.UnloadScene(2);
        SceneManager.LoadScene(0);
    }
}
