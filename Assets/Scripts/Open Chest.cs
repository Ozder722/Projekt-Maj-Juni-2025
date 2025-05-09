
using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject chestClosedSprite;
    public GameObject chestOpenedSprite;
    public GameObject ePrompt;

    private bool playerInRange = false;
    private bool isOpened = false;

    void Start()
    {
        ePrompt.SetActive(false);
        chestOpenedSprite.SetActive(false);
    }

    void Update()
    {
        if (playerInRange && !isOpened && Input.GetKeyDown(KeyCode.E))
        {
            OpenChest();
        }
    }

    void OpenChest()
    {
        isOpened = true;
        chestClosedSprite.SetActive(false);
        chestOpenedSprite.SetActive(true);
        ePrompt.SetActive(false);
        // You can add loot logic here too
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isOpened)
        {
            playerInRange = true;
            ePrompt.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            ePrompt.SetActive(false);
        }
    }
}
