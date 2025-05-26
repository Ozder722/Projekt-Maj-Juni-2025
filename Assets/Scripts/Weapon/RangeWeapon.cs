    using UnityEngine;

public abstract class RangedWeapon : Weapon
{
    [SerializeField] protected float firerate = 0.5f;
    [SerializeField] protected float bulletspeed = 5f;
    [SerializeField] protected float bulletRange = 10f;
    [SerializeField] protected GameObject bulletPrefab;
    [SerializeField] protected Transform firePoint;
    protected float lifespan;

    protected float nextFireTime;


    protected abstract void Fire();



    protected override void Attack()
    {
        if (Time.time >= nextFireTime)
        {
            nextFireTime = Time.time + firerate;
            Fire(); 
        }
        
    }
}
