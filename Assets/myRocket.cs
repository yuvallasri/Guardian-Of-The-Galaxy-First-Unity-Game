using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myRocket : MonoBehaviour
{
    public GameObject rocket;
    GameObject rocketclone;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

        {
            rocketclone = Instantiate(rocket, transform.position, Quaternion.identity) as GameObject;
            Destroy(rocketclone, 3);

        }
    }
}
