using System;
using System.Collections;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    public int maxHealth = 100;
    private float currentHealth;
    private bool invincibility;
    public int tradeCoin = 10;
    public int tradeHealth = 5;
    public CoinComponent coinComponent;

    public delegate void OnHealthChangedHandler(float newHealth, float amountChanged);
    public event OnHealthChangedHandler OnHealthChanged;

    public delegate void OnHealthInitializedHandler(float newHealth);
    public event OnHealthInitializedHandler OnHealthInitialized;


    private void Start()
    {
        currentHealth = maxHealth;
        OnHealthInitialized?.Invoke(currentHealth);
        coinComponent.newCoinAmount += newCoinAmount;
    }

    private void newCoinAmount(float newCoinAmount, float amountChanged)
    {
        if (!invincibility)
        {
            (newCoinAmount) = tradeCoin;
            AddHealth(tradeHealth);
            coinComponent.RemoveCoin(tradeCoin);
            invincibility = true;
            StartCoroutine(ResetInvincibility(3));
        }
    }

    public void ReceiveDamage(float amount)
    {
        if(!invincibility)
        {
            currentHealth -= amount;
            OnHealthChanged?.Invoke(currentHealth, amount);
            invincibility = true;
            StartCoroutine(ResetInvincibility(3));
        }
    }

    IEnumerator ResetInvincibility(float resetTime)
    {
        yield return new WaitForSeconds(resetTime);
        invincibility = false;
    }

    public void AddHealth(float amount)
    {
        currentHealth += amount;
        OnHealthChanged?.Invoke(currentHealth, amount);
        //Debug.Log(currentHealth);
    }
}
