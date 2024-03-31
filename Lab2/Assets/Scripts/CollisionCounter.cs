using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CollisionCounter : MonoBehaviour
{
    private int collisionCount = 0; // Лічильник зіткнень

    // Викликається, коли цей об'єкт зіткнеться з іншим
    private void OnCollisionEnter(Collision collision)
    {
        // Перевіряємо, чи зіткнення відбулося з перешкодою (об'єкт з тегом "Wall")
        if (collision.gameObject.CompareTag("Cube") && gameObject.CompareTag("Player"))
        {
            // Збільшуємо лічильник зіткнень
            collisionCount++;

            // Оновлюємо відображення кількості зіткнень (використовуючи Debug.Log з UnityEngine)
            UnityEngine.Debug.Log("Зіткнень гравця з перешкодами: " + collisionCount);
        }
    }
}