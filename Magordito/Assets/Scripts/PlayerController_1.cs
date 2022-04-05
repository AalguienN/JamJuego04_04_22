using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_1 : MonoBehaviour
{
    public Vector3 move_vector;
    public GameObject bal;
    private Animator an;
    private bool move=false;
   
    public Vector3 movement;
    [Header("CONTROLES . . . . ")]
    [Header("Movimiento")]
    public string u_key;  //up key    
    public string d_key;  //down key
    public string r_key;  //right key
    public string l_key;  //left key
    public string s_key;  //left key
    [Header("Zona del Terreno")]
    public float maxUp;
    public float maxDown;
    public float maxRight;
    public float maxLeft;
    [Header("Constantes")]
    public float speed;
    [Header("Visual")]
    public GameObject spriteRender;
    public GameObject objetosExtra;


    private void Start()
    {
        move_vector = new Vector3(0, 0, 0);
        an = GetComponent<Animator>();
    }
    private void Update()
    {
       
        move_vector.x = 0;
        move_vector.z = 0;
        //Input
        if (transform.position.z <= maxUp)
            if (Input.GetKey(u_key) || Input.GetKey(u_key.ToLower())) { move_vector.z += 0.5f; }
        if (transform.position.z >= maxDown)
            if (Input.GetKey(d_key) || Input.GetKey(d_key.ToLower())) { move_vector.z -= 0.5f; }
        if (transform.position.x <= maxRight)
            if (Input.GetKey(r_key) || Input.GetKey(r_key.ToLower())) { move_vector.x += 1; }
        if (transform.position.x >= maxLeft)
            if (Input.GetKey(l_key) || Input.GetKey(l_key.ToLower())) { move_vector.x -= 1; }

        if (Input.GetKeyDown(s_key) || Input.GetKeyDown(s_key.ToLower())) { Instantiate(bal, transform.position,transform.rotation); }

        //Accion
        if (move_vector == Vector3.zero)
        {
            move = true;
        }
        else
        {
            move = false;
        }
        an.SetBool("Quieto", move);
        an.SetFloat("V", Mathf.Abs(move_vector.x) + Mathf.Abs(move_vector.z));
        transform.Translate(move_vector * Time.deltaTime * speed);
        movement = move_vector;
        if (move_vector.x < 0) {
            objetosExtra.transform.rotation = Quaternion.Euler(0, 180, 0);
            spriteRender.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (move_vector.x > 0) {
            objetosExtra.transform.rotation = Quaternion.Euler(0, 0, 0);
            spriteRender.GetComponent<SpriteRenderer>().flipX = false;
        }

    }
}
