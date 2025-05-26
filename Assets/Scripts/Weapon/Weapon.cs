using Unity.VisualScripting;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private float damage =1f;
    [SerializeField] protected KeyCode attackInputKey = KeyCode.Mouse0;
    // Update is called once per frame
    protected virtual void Update()
    {
        
        if (Input.GetKey(attackInputKey))
        {
            Attack();
            Debug.Log("SKYDDD");
        }
          
    }

    protected abstract void Attack();
    


}
