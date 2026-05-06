using System;
using System.Collections;
using UnityEngine;

public class CoinComponent : MonoBehaviour {
    public float currentCoinAmount;

    public delegate void OnCoinChangedHandler(float newCoinAmount, float amountChanged);
    public event OnCoinChangedHandler newCoinAmount;

    public delegate void OnCoinInitializedHandler(float currentCoinAmount);
    public event OnCoinInitializedHandler OnCoinInitialized;
        private void Start()
    {
        currentCoinAmount = 0;
        OnCoinInitialized?.Invoke(currentCoinAmount);  

    }
    public void AddCoin(float amount)
    {
        Debug.Log(amount);
        currentCoinAmount += amount;
        newCoinAmount?.Invoke(currentCoinAmount, amount);
    }
    public void RemoveCoin(float amount)
    {
        {
            currentCoinAmount -= amount;
            newCoinAmount?.Invoke(currentCoinAmount, amount);
        }
    }
}
