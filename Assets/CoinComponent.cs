using System;
using System.Collections;
using UnityEngine;

public class CoinComponent : MonoBehaviour {
    public float currentCoinAmount;


    public delegate void OnCoinChangedHandler(float newCoinAmount, float amountChanged);
    public event OnCoinChangedHandler newCoinAmount;

    public delegate void OnCoinInitializedHandler(float newCoinAmount);
    public event OnCoinInitializedHandler OnCoinInitialized;
    
    public void AddCoin(float amount)
    {
        currentCoinAmount += amount;
        newCoinAmount?.Invoke(currentCoinAmount, amount);
        Debug.Log(currentCoinAmount);
    }
}
