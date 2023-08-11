using UnityEngine;

public class ExitSign:MonoBehaviour
{
    public void ShowExit()
    {
        Container.Get<MainSceneUI>().EnableMenuButton();
    }
}