using System.Collections;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        NewMethod(sceneName);
    }

    private static void NewMethod(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
