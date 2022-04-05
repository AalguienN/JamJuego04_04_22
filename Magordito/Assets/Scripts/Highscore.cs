using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    private int highscore;
    public Text text;
    
   

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.GetInt("Highscore", highscore);
        if (highscore != null)
        {
            text.text = "highscore: " + highscore;
        }
    }

    
}
