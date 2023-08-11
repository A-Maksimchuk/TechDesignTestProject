using UnityEngine;

public class MainSceneUI:MonoBehaviour
{
    [SerializeField] private GameObject menuButton;

    public void EnableMenuButton()
    {
        menuButton.SetActive(true);
    }
}