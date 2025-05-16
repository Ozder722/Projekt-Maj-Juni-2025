using Unity.VisualScripting;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private float damage =1f;


    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Attack();
            Debug.Log("SKYDDD");
        }
          
    }

    protected abstract void Attack();
    


}
