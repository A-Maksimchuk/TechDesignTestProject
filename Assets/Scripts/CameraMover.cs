using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private FreezeAxis freezeAxis;
    [SerializeField] private float moveSpeed = 1;
    private Coroutine _mover;
    private const float MOVE_INACCURACY = 0.1f;
    
    public void MoveToPoint(Vector3 point)
    {
        var position = transform.position;
        var targetPoint = new Vector3(freezeAxis.X ? position.x : point.x,
            freezeAxis.Y ? position.y : point.y, freezeAxis.Z ? position.z : point.z);
        if(_mover!=null)
            StopCoroutine(_mover);
        _mover = StartCoroutine(IEMoveToPoint(targetPoint));
    }

    private IEnumerator IEMoveToPoint(Vector3 point)
    {
        while (Vector3.Distance(transform.position, point)>MOVE_INACCURACY)
        {
            transform.position = Vector3.MoveTowards(transform.position, point, 
                moveSpeed * Time.deltaTime);
            yield return null;
        }
    }

    [Serializable]
    public struct FreezeAxis
    {
        public bool X;
        public bool Y;
        public bool Z;
    }
}
