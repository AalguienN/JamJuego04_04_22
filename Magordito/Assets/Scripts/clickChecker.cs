using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickChecker : MonoBehaviour
{
    GameStateScr gm;
    private void Start()
    {
        gm = gameObject.GetComponent<GameStateScr>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                switch (hit.collider.tag) {
                    case "ObjetoNormal":
                        hit.collider.gameObject.GetComponent<ObjetoNormal>().OnClick();
                        break;
                    case "ObjetoCorrompido":
                        hit.collider.gameObject.GetComponent<ObjetoCorrompidoScr>().OnClick();
                        break;
                    default:
                        Debug.Log("Ray Cast : Objeto SinTag");
                        break;
                
                }
                Debug.Log(gm.getVidaPlayer() +"::::"+ gm.getPoints() + "/" + gm.pointsToWin); ///Linea COMENTABLE AAAAAAAAAAAAAAAA
            }
        }
    }
    
}
