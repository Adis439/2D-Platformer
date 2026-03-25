using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float Maxhealth = 10;
    private float Health = 10;


    void Start()
    {
        //Rigidbody2D.Equals = Maxhealth;
        Debug.Log(Health);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddDamage(float damage)
    {
        Health -= damage;
        Debug.Log(Health);

        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void AddHealth(float HealingValue)
    {
        Health += HealingValue;
        Debug.Log(Health);

    }

}
