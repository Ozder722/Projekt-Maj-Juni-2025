using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float playerhealth;
    [SerializeField] private Text healthText;

    public void UpdateHealth()
    {
        healthText.text = playerhealth.ToString("0");
    }

}
