using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    public void OnClicked()
    {
        Container.Get<CameraMover>().MoveToPoint(transform.position);
    }
}
