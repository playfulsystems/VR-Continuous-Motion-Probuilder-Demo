using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    float time = 0;
    Vector3 originalPos, startPos, targetPos;

    void Start()
    {
        originalPos = startPos = targetPos = transform.position;
    }
    void Update()
    {
        transform.position = Vector3.Lerp(startPos, targetPos, time);
        time += Time.deltaTime;
    }
    public void MoveTo(Vector3 newTargetPos)
    {
        startPos = transform.position;
        targetPos = newTargetPos;
        time = 0;
    }
    public void MoveBack()
    {
        MoveTo(originalPos);
    }
}