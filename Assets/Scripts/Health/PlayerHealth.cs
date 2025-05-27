using TMPro;
using UnityEngine;

public class PlayerHealth : HealthController, IDamageAble
{

    public void TakeDamage(int damage)
    {
        UpdateHealth(damage);
    }

    
}
