using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class history : MonoBehaviour
{
    private int counter = 0;
    public Sprite h1;
    public Sprite h2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) { counter++; }
        switch (counter) {
            case 0:
                GetComponent<Image>().sprite = h1;
                break;

            case 1: 
                GetComponent<Image>().sprite = h2;
                break;

            default:
                SceneManager.LoadScene("EscenaPruebas2");
                break;

        }
    }
}
