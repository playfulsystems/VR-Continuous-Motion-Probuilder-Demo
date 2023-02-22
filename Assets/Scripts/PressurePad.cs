using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePad : MonoBehaviour
{
    public MoveToTarget ObjectToMove;
    public Vector3 TargetPos;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Red")
        {
            ObjectToMove.MoveTo(TargetPos);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Red")
        {
            ObjectToMove.MoveBack();
        } 
    }

}
