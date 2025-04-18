using UnityEngine;

public class StructureHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    public float damageInterval = 2f; // Kaç saniyede bir can azalsın
    public int damageAmount = 10;

    void Start()
    {
        currentHealth = maxHealth;
        InvokeRepeating("TakeDamage", damageInterval, damageInterval);
    }

    void TakeDamage()
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Puanı oyuncuya ilet
        ScoreManager.instance.AddScore(10);

        Destroy(gameObject);
    }
}
