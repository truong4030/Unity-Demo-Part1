using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 0.2f;

    private float nextFireTime = 0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    void Shoot()
    {
        if (bulletPrefab == null || firePoint == null)
        {
            Debug.LogError("FirePoint or BulletPrefab is NULL");
            return;
        }

        Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
    }
}
