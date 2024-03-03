using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public float radius = 2f; // радіус циклоїди
    public float speed = 2f; // швидкість руху кулі

    private float timeCounter = 0f;

    void Update()
    {
        // Обчислення x та y за параметричним рівнянням циклоїди
        float x = radius * (Mathf.Cos(timeCounter) + timeCounter * Mathf.Sin(timeCounter));
        float y = radius * (Mathf.Sin(timeCounter) - timeCounter * Mathf.Cos(timeCounter));

        // Оновлення позиції кулі
        transform.position = new Vector3(x, y, 0f);

        // Інкремент часу
        timeCounter += Time.deltaTime * speed;
    }
}
