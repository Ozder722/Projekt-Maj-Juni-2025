using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthController : MonoBehaviour
{
    private void Start()
    {
        UpdateHealth();
    }

    public float playerHealth;
    [SerializeField] private Text healthText;

    //[SerializeField] private TextMeshProUGUI healthText;

    public void UpdateHealth()
    {
        healthText.text = playerHealth.ToString("0");
    }

}
