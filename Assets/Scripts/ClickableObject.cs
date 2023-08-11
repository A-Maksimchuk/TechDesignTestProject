using System;
using UnityEngine;
using UnityEngine.Events;

public class ClickableObject : MonoBehaviour
{
    [SerializeField] private UnityEvent onClick;
    private float _onDownTime;
    private const float MAX_CLICK_DELAY = 0.3f;
    private void OnMouseDown()
    {
        _onDownTime = Time.time;
    }

    private void OnMouseUp()
    {
        if(Time.time-_onDownTime<MAX_CLICK_DELAY)
            onClick.Invoke();
    }
}
