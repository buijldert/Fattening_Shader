using UnityEngine;
using System.Collections;

public class FattenCharacter : MonoBehaviour
{
    //store current fat amount
    [Range(0, 1)]
    [SerializeField]private float _currentFat = 0.5f;
    //max number of fat
    private float _maxFat = 1;
    //store fatloss rate
    private float _fatLossAmount = 0.01f;
    //store fatloss time
    private int _fatLossDelay = 1;

    //event for sending fatamount
    public delegate void SendCurrentFatAmountAction(float currentFat);
    public static event SendCurrentFatAmountAction OnSendCurrentFatAmount;

    //event for sending gamover
    public delegate void GameOverAction();
    public static event GameOverAction OnGameOver;

    //use this for initialization
    void OnEnable()
    {
        Candy.OnCandyPickup += Fatten;
        SendCurrentFatAmount();
        StartCoroutine(LoseFat());
    }

    //fatten the character
    public void Fatten(float fattenAmount)
    {
        if(_currentFat < _maxFat )
        {
            _currentFat += fattenAmount;
            SetFat();
            SendCurrentFatAmount();
        }
    }
    
    //fat loss delay function
    IEnumerator LoseFat()
    {
        yield return new WaitForSeconds(_fatLossDelay);
        _currentFat -= _fatLossAmount;
        SetFat();
        SendCurrentFatAmount();
        StartCoroutine(LoseFat());
        if(_currentFat < 0)
        {
            _currentFat = 0;
            if(OnGameOver != null)
            {
                OnGameOver();
            }
        }
    }

    //send the current fat amount
    void SendCurrentFatAmount()
    {
        if (OnSendCurrentFatAmount != null)
        {
            OnSendCurrentFatAmount(_currentFat);
        }
    }

    //set fat amount
    void SetFat()
    {
        GetComponentInChildren<Renderer>().material.SetFloat("_Amount", _currentFat);
    }

    //use this for exit
    void OnDisable()
    {
        Candy.OnCandyPickup -= Fatten;
    }
}