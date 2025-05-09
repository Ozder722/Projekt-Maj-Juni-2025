using UnityEngine;

public class TouchDamage : MonoBehaviour
{

    [SerializeField] private float touchDamage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Damage(collision.GetComponent<HealthController>());
        }
    }

    void Damage(HealthController healthController)
    {
        healthController.UpdateHealth(-touchDamage);
        this.gameObject.SetActive(false);

        
    }
}
