using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public float maxHealth = 100f;  // Max health of the character
    private float currentHealth;     // Current health of the character
    public Slider healthSlider;      // Reference to a UI slider for health display

    void Start()
    {
        currentHealth = maxHealth;   // Initialize current health to max health
        UpdateHealthUI();
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;   // Decrease health by damage amount
        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth); // Prevent negative health
        UpdateHealthUI();

        if (currentHealth <= 0f)
        {
            Die();
        }
    }

    void UpdateHealthUI()
    {
        healthSlider.value = currentHealth / maxHealth; // Update health UI slider
    }

    void Die()
    {
        // Handle character death here (e.g., play animation, disable controls, etc.)
        Debug.Log("Character has died.");
    }
}
