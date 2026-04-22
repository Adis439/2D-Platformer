
using System;
using TMPro;
using UnityEngine;

public class UI_CoinDisplay : MonoBehaviour
{
    public CoinComponent coinComponent;
    public TextMeshProUGUI textComponent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        coinComponent.newCoinAmount += newCoinAmount;
        coinComponent.OnCoinInitialized += OnCoinInitialized;
    }

    private void OnCoinInitialized(float currentCoinAmount)
    {
        textComponent.text = currentCoinAmount.ToString();
    }

    private void newCoinAmount(float newCoinAmount, float amountChanged)
    {
        //Debug.Log(newCoinAmount + ":" + amountChanged);
        textComponent.text = newCoinAmount.ToString();
    }
}