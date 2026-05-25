using UnityEngine;

public class CoinPack : MonoBehaviour
{
    public float coinValue = 5;
    private void OnTriggerEnter2D(Collider2D other)
    {

            other.GetComponent<CoinComponent>().AddCoin(coinValue);
            Destroy(gameObject);
     
    }
}