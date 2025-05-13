using UnityEngine;

public class TouchDamage : MonoBehaviour, IDamageAble
{

    [SerializeField] private int touchDamage;

    public void TakeDamage(int damage)
    {
        GetComponent<HealthController>().UpdateHealth(-damage);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<IDamageAble>()?.TakeDamage(-touchDamage);
            Destroy(this.gameObject);
        }

    }

   
}
