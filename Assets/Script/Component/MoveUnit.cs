using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUnit : MonoBehaviour
{
    public Vector3 heading;
    public float speed;
    
    void Start()
    {
        heading = Vector3.forward;
    }

    void Update()
    {
        transform.position += heading * speed * Time.deltaTime;
    }
}
