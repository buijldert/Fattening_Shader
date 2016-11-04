using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadAScene : MonoBehaviour
{
    //set scenename to load here
    [SerializeField]private string _sceneToLoad;

    //load the scene
    public void LoadTheScene()
    {
        SceneManager.LoadScene(_sceneToLoad);
    }
}
