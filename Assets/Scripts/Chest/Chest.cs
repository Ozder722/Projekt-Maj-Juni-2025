using Unity.VisualScripting;
using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
{
    public bool IsOpened { get; private set; }
    public string ChestID { get; private set; }
    public GameObject itemPrefab;
    public Sprite openedSprite;
    

    void Start()
    {
        ChestID ??= Globalhelper.GenerateUniqueID(gameObject);
    }

    public bool CanInteract() 
    { 
        return IsOpened; 
    }

    public void Interact()
    {
        if (!CanInteract()) return;
        OpenChest();
    }
     
    public void OpenChest()
    {
        SetOpened(true);
        if(itemPrefab)
        {
            GameObject droppedItem = Instantiate(itemPrefab);
        }
    }
    public void SetOpened(bool opened)
    {
        
        if(IsOpened = opened)
        {
            GetComponent<SpriteRenderer>().sprite = openedSprite;
        }
    }
}