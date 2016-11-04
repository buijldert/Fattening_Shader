using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FatBar : MonoBehaviour
{
    //store the fatbar image
    [SerializeField] private Image _fatBar;

	// Use this for initialization
	void OnEnable ()
    {
        FattenCharacter.OnSendCurrentFatAmount += ChangeFatBar;
	}

    //change the fillamount of the fatbar
    void ChangeFatBar(float currentFat)
    {
        _fatBar.fillAmount = currentFat;
    }
	
	//use this for exit
	void OnDisable ()
    {
        FattenCharacter.OnSendCurrentFatAmount += ChangeFatBar;
    }
}
