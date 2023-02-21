using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePad : MonoBehaviour
{
    public GameObject ObjectToMove;
    public Vector3 OpenPos;
    public Vector3 ClosedPos;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Red")
        {
            ObjectToMove.GetComponent<MoveToTarget>().targetPos = OpenPos;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Red")
        { 
            ObjectToMove.GetComponent<MoveToTarget>().targetPos = ClosedPos;
        } 
    }

}
