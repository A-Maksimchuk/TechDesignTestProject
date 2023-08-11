using System;
using UnityEngine;

public class MainContext:MonoBehaviour
{
    [SerializeField] private MainSceneUI mainUI;
    [SerializeField] private CameraMover cameraMover;

    private void Awake()
    {
        Container.Bind(cameraMover);
        Container.Bind(mainUI);
    }
}