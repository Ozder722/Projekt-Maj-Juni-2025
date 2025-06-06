using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public abstract class HealthController : MonoBehaviour
{
    public float health;
    public float maxHealth;

    [SerializeField] private Slider healthText;
    private void Start()
    {
        health = maxHealth;
        healthText.maxValue = maxHealth;
        UpdateHealth(0);
    }

    public virtual void UpdateHealth(float damage)
    {
        Debug.Log("updatehealth");
        health += damage;
        healthText.value = health;
        if (health <= 0f)
        {
            DieAndRespawn();
            Debug.Log("die");
        }

    }

    protected virtual void DieAndRespawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
