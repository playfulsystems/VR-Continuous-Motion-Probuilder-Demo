using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    public Vector3 targetPos;
    float speed = 0.4f;

    void Start()
    {
        targetPos = transform.position;
    }


    void Update()
    {
        Vector3 vectorToTarget = targetPos - transform.position;
        if (vectorToTarget.magnitude > 0.01f)
        {
            transform.position += vectorToTarget.normalized * speed * Time.deltaTime;
        }
        else
        {
            transform.position = targetPos;
        }
    }
}
