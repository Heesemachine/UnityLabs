using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateScript : MonoBehaviour
{
    public float radius = 2f; // початковий радіус спіралі
    public float angularSpeed = 1f; // кутова швидкість
    public float verticalSpeed = 1f; // вертикальна швидкість

    private float timeCounter = 0f;

    void Update()
    {
        // Обчислення координат за параметричним рівнянням спіралі
        float x = radius * Mathf.Cos(timeCounter);
        float y = radius * Mathf.Sin(timeCounter);

        // Оновлення позиції платформи
        transform.position = new Vector3(x, y, timeCounter * verticalSpeed);

        // Інкремент часу
        timeCounter += Time.deltaTime * angularSpeed;
    }
}
