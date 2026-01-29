using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public Transform firePoint;
    public float shootingInterval = 0.2f;

    private float lastBulletTime;

    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time > lastBulletTime)
        {
            Shoot();
            lastBulletTime = Time.time + shootingInterval;
        }
    }

    void Shoot()
    {
        if (bulletPrefabs == null || firePoint == null) return;

        Instantiate(
            bulletPrefabs,
            firePoint.position,
            Quaternion.identity
        );
    }
}
