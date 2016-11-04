using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOver : MonoBehaviour
{
    //use this for initialization
    void OnEnable()
    {
        FattenCharacter.OnGameOver += GameOverAction;
    }
    //load gameoverscene
    void GameOverAction()
    {
        SceneManager.LoadScene("gameoverscene");
    }
    //use this for exit
    void OnDisable()
    {
        FattenCharacter.OnGameOver -= GameOverAction;
    }
}