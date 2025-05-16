using UnityEngine;

public class EnemyHealth : HealthController, IDamageAble
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
        UpdateHealth(0);
    }

    public void TakeDamage(int damage)
    {
        UpdateHealth(damage);
    }

    protected override void DieAndRespawn()
    {
        Destroy(this.gameObject);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    
}
