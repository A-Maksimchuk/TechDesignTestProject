using System;
using UnityEngine;

public class MainContext:MonoBehaviour
{
    [SerializeField] private MainSceneUI mainUI;
    [SerializeField] private CameraMover cameraMover;
    [SerializeField] private SpineCharacterController spineCharacterController;

    private void Awake()
    {
        Container.Bind(cameraMover);
        Container.Bind(mainUI);
        Container.Bind(spineCharacterController);
    }
}