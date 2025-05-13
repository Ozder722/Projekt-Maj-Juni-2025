using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public abstract class HealthController : MonoBehaviour
{
    public float health = 5;
    [SerializeField] private Slider healthText;
    private void Start()
    {
        UpdateHealth(0);
    }

    public virtual void UpdateHealth(float damage)
    {
        health += damage;
        healthText.value = health;
        if (health <= 0f)
        {
            DieAndRespawn();
        }

    }

    public virtual void DieAndRespawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
