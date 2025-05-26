using UnityEngine;

public class EnemyHealth : HealthController, IDamageAble
{
    
    public void TakeDamage(int damage)
    {
        UpdateHealth(damage);
    }

    protected override void DieAndRespawn()
    {
        Destroy(this.gameObject);
    }
    
}
