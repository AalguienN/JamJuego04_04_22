using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_1 : MonoBehaviour
{
    private Vector3 move_vector;
    [Header("CONTROLES . . . . ")]
    [Header("Movimiento")]
    public string u_key;  //up key    
    public string d_key;  //down key
    public string r_key;  //right key
    public string l_key;  //left key
    [Header("Constantes")]
    public float speed;


    private void Start()
    {
        move_vector = new Vector3(0, 0, 0);
    }
    private void Update()
    {
        move_vector.x = 0;
        move_vector.z = 0;
        //Input
        if (Input.GetKey(u_key) || Input.GetKey(u_key.ToLower())) { move_vector.z += 1; }
        if (Input.GetKey(d_key) || Input.GetKey(d_key.ToLower())) { move_vector.z -= 1; }
        if (Input.GetKey(r_key) || Input.GetKey(r_key.ToLower())) { move_vector.x += 1; }
        if (Input.GetKey(l_key) || Input.GetKey(l_key.ToLower())) { move_vector.x -= 1; }

        //Accion
        transform.Translate(move_vector * Time.deltaTime * speed);

    }
}
