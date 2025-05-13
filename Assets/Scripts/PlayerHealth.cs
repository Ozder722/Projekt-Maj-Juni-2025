using TMPro;
using UnityEngine;

public class PlayerHealth : HealthController, IDamageAble
{

    void Start()
    {
        health = 100;
        UpdateHealth(0);
    }

    public void TakeDamage(int damage)
    {
        UpdateHealth(damage);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
