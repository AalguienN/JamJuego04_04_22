using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fantasmaComportamiento : MonoBehaviour
{
    private Vector3 dir;
    private GameObject player;
    public float speed;
    private GameStateScr gs;

    private int hp = 3;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        changeDir();
        gs = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameStateScr>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, this.transform.position) > 30) { changeDir(); }
        if (transform.position.y < -2.5) { changeDir(); dir.y = Random.Range(1, 4); }
        if (transform.position.y > 15) { changeDir();  dir.y = Random.Range(-3, 0); }
        if (transform.position.z > 0) { dir.z = -1; }
        if (transform.position.x > 40) { dir.x -= 1; }
        if (transform.position.x < -40) { dir.x += 1; }
        else if (dir.z < 0 && transform.position.z <= 0) { dir.z = 0; }
        transform.Translate(dir * Time.deltaTime * speed);
    }

    private void changeDir() {
        dir = new Vector3(Random.Range(-3, 4), Random.Range(-3, 4), 0);
    }
    public void OnClick() {
        hp--;

        if (hp <= 0)
        {
            gs.addPoint();
            Destroy(this.gameObject);
        }
    }
}
