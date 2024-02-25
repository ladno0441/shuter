using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public Transform firePoint; // Point where the bullets are spawned
    public GameObject bulletPrefab; // Prefab of the bullet

    public float bulletForce = 20f; // Force applied to the bullet when shot

    // Update is called once per frame
    void Update()
    {
        // Check if the player wants to shoot
        if (Input.GetButtonDown("Fire1")) // Change "Fire1" to any input axis you want to use for shooting
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Spawn a bullet at the fire point
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Get the Rigidbody component of the bullet
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        // Apply force to the bullet
        rb.AddForce(firePoint.forward * bulletForce, ForceMode.Impulse);
    }
}
