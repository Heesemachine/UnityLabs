using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

//TASK 1

//Rigidbody - це компонент у Unity, який використовується для моделювання фізики об'єктів.
//В основному, цей компонент використовується для об'єктів, які повинні підкорятися законам фізики, таким як гравітація,
//столкнувшись з іншими об'єктами, відскакувати, крутитися тощо.
//Коли додаєте компонент Rigidbody до об'єкта в Unity, ви дозволяєте йому взаємодіяти з фізичним світом в грі.
//Rigidbody відповідає за обчислення руху об'єкта з урахуванням сили,
//маси, швидкості, кутової швидкості та інших фізичних параметрів.
//Наприклад, якщо ви хочете, щоб об'єкт підкорявся гравітації
//та взаємодіяв з іншими об'єктами, вам зазвичай слід додати компонент Rigidbody до цього об'єкта.
//Користувач може керувати рухом об'єкта з Rigidbody за допомогою скриптів,
//задавати сили, керувати швидкістю, обертанням тощо.

public class CarMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // швидкість руху автомобіля
    public float rotationSpeed = 100f; // швидкість повороту автомобіля


    //TASK 2
    void Start()
    {
        Vector3 vector1 = new Vector3(-1f, 5f, 7f);
        Vector3 vector2 = new Vector3(-2f, 0f, 6f);

        Vector3 crossProduct = Vector3.Cross(vector1, vector2);
        UnityEngine.Debug.Log("Векторний добуток: " + crossProduct);
    }


    //TASK 3

    void Update()
    {
        // Рух вперед
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        // Рух назад
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }

        // Поворот вліво
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }

        // Поворот вправо
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}
