using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketForce : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        Vector3 position = this.transform.position;
        position.y++;
        this.transform.position = position;
    }
}
