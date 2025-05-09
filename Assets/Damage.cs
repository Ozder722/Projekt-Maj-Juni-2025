using UnityEngine;

public class TouchDamage : MonoBehaviour
{

    [SerializeField] private float touchDamage;
    [SerializeField] private HealthController healthController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Damage();
        }
    }

    void Damage()
    {
        healthController.playerHealth = healthController.playerHealth - touchDamage;
        healthController.UpdateHealth();
        this.gameObject.SetActive(false);

        
    }
}
