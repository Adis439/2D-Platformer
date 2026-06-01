using UnityEngine;


public class CoinPack : MonoBehaviour
{
    //private Animator _animator;
    public float coinValue = 5;
    private void OnTriggerEnter2D(Collider2D other)
    {

            //_animator = GetComponent<Animator>();
            other.GetComponent<CoinComponent>().AddCoin(coinValue);

            //_animator.SetTrigger("IsOpened"); 
            
            Destroy(gameObject);
     
    }
}