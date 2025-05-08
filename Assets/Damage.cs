using UnityEngine;

public class TouchDamage : MonoBehaviour
{

    [SerializeField] private float touchDamage;
    [SerializeField] private HealthController HealthController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Damage();
        }
    }

    void Damage()
    {
        HealthController.playerhealth = HealthController.playerhealth - touchDamage;
        HealthController.UpdateHealth();
        this.gameObject.SetActive(false);
    }
}
