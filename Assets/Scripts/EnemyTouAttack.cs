using UnityEngine;

public class EnemyTouAttack : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private int damage = 5;
    [SerializeField] private int damageableLayer = 6;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.layer + " : " + (6 << damageableLayer));
        if (collision.gameObject.layer == damageableLayer)
        {
            collision.gameObject.GetComponent<IDamageAble>()?.TakeDamage(-damage);
            Debug.Log("spiller skadet");
            
        }
    }
}

