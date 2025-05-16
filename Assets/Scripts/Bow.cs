using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class Bow : RangedWeapon
{
 

    protected override void Fire()
    {
        GameObject arrow = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;
        Vector2 direction = (mousePos - firePoint.position).normalized;

        Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();


        rb.linearVelocity = direction * bulletspeed;


        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        arrow.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

    }
}
