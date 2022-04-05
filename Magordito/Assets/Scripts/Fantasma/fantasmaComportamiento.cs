using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fantasmaComportamiento : MonoBehaviour
{
    private Vector3 dir;
    private GameObject player;
    public float speed;
    private GameStateScr gs;
    public GameObject explo;


    private int hp = 3;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        changeDir();
        gs = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameStateScr>();
        Instantiate(explo, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, this.transform.position) > 30) { changeDir(); }
        if (transform.position.y < -2.5) { changeDir(); dir.y = Random.Range(1, 3); }
        if (transform.position.y > 15) { changeDir();  dir.y = Random.Range(-2, 0); }
        if (transform.position.z > 0) { dir.z = -1; }
        if (transform.position.x > 40) { dir.x -= 1; }
        if (transform.position.x < -40) { dir.x += 1; }
        else if (dir.z < 0 && transform.position.z <= 0) { dir.z = 0; }
        transform.Translate(dir * Time.deltaTime * speed);
    }

    private void changeDir() {
        dir = new Vector3(Random.Range(-2, 3), Random.Range(-2, 3), 0);
    }
    public void OnClick() {
        hp--;
        Instantiate(explo, transform.position, transform.rotation);

        if (hp <= 0)
        {
            gs.addPoint();
            Destroy(this.gameObject);
        }
    }
}
