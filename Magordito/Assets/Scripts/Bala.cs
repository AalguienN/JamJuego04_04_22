using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    Rigidbody rb;
    public PlayerController_1 pc1;
    public ParticleSystem particle;
    public bool colision=false;
    public Light l;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        particle = GetComponent<ParticleSystem>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!colision)
        {
            Mover();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {

        }
        else 
        {
            particle.Play();
            rb.velocity = Vector3.zero;
            colision = true;
            Destroy(gameObject, 1.5f);


        }
        

    }
    private void Mover()
    {
        rb.AddForce(Vector3.right, ForceMode.Force) ;
    }
}
