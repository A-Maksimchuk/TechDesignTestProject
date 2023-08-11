using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    [SerializeField] private CameraMover cameraMover;

    public void OnClicked()
    {
        cameraMover.MoveToPoint(transform.position);
    }
}
