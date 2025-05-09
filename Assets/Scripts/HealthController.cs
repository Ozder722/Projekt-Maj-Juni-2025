using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    float playerHealth = 100;
    [SerializeField] private TMP_Text healthText;
    private void Start()
    {
        UpdateHealth(0);
    }

    public void UpdateHealth(float damage)
    {
        playerHealth += damage;
        healthText.text = playerHealth.ToString("0");
        if (playerHealth <= 0f)
        {
            DieAndRespawn();
        }

    }

    void DieAndRespawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
