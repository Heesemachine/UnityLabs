using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class TakeDamageCollider : MonoBehaviour
{
    public HealthBar healthBar;

    public int maxHealth = 100;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    // Викликається, коли цей об'єкт зіткнеться з іншим
    private void OnCollisionEnter(Collision collision)
    {
        // Перевіряємо, чи зіткнення відбулося з перешкодою (об'єкт з тегом "Wall")
        if (collision.gameObject.CompareTag("Pastka") && gameObject.CompareTag("Player"))
        {
            TakeDamage(20);
        }
    }
}