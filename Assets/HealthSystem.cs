using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public Transform respawnPoint; // The point where the player will respawn

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth);
        UpdateHealthBar();
        if (currentHealth <= 0f)
        {
            DieAndRespawn();
        }
    }

    private void DieAndRespawn()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void UpdateHealthBar()
    {
        // Update the health bar's value to reflect the current health
        //healthBar.value = currentHealth;
    }

    public void RegenerateHealth(float regenAmount)
    {
        currentHealth += regenAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth);
        UpdateHealthBar();
    }
}
