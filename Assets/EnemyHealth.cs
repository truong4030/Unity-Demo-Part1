using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 3;
    public GameObject explosionPrefab;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}