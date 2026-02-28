using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3;                 // số máu của player
    public GameObject gameOverCanvas;      // canvas game over

    void Start()
    {
        // đảm bảo Game Over không hiện khi bắt đầu
        if (gameOverCanvas != null)
        {
            gameOverCanvas.SetActive(false);
        }
    }

    // hàm bị trúng đạn
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
        Debug.Log("Player Dead");

        if (gameOverCanvas != null)
        {
            gameOverCanvas.SetActive(true);
        }

        gameObject.SetActive(false); // tắt player
    }

    // khi va chạm với enemy
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            TakeDamage(1);
        }
    }
}