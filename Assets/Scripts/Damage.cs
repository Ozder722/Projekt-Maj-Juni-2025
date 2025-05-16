using UnityEngine;


public class RangeDamage : MonoBehaviour
{

    [SerializeField] private int damage = 5;
    [SerializeField] private int damageableLayer = 7;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.layer + " : " + (7<<damageableLayer));
        if (collision.gameObject.layer == damageableLayer)
        {
            collision.gameObject.GetComponent<IDamageAble>()?.TakeDamage(-damage);
            Debug.Log("av");
            Destroy(gameObject);
        }
    }
}
