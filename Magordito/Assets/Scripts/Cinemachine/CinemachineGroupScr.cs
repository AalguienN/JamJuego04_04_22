using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinemachineGroupScr : MonoBehaviour
{
    [Header("Targets")]
    public GameObject[] targets;
    [Header("VCamera position")]
    public Vector3 offset;
    private Vector3 pos;

    // Update is called once per frame
    void Update()
    {
        pos = new Vector3(0, 0, 0);
        for (int i = 0; i < targets.Length; i++) {
            pos += targets[i].transform.position;
        }
        pos /= targets.Length;
        pos += offset;
        transform.position = pos;
    }
}
