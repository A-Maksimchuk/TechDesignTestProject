using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    public void OnClicked()
    {
        Vector3 position = transform.position;
        Container.Get<CameraMover>().MoveToPoint(position);
        Container.Get<SpineCharacterController>().MoveToPoint(position);
    }
}
