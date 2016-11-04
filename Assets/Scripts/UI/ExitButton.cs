using UnityEngine;
using System.Collections;

public class ExitButton : MonoBehaviour
{
    //exit the game (doesnt work in webgl/web builds)
    public void ExitGame()
    {
        Application.Quit();
    }
}
