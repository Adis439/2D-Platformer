using UnityEngine;
public int coinValue = 5;
public class CoinPack : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {

        CoinComponent coinComponent = other.GetComponent<CoinComponent>();

        if (coinComponent != null)
        {
            coinComponent.AddCoin(coinValue);
            Destroy(gameObject);
        }
    }
}