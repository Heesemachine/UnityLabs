using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f; // �������� ���� ���������
    public float rotationSpeed = 100f; // �������� �������� ���������
    public float accelerationMultiplier = 2f; // ������� �����������
    public float accelerationDuration = 5f; // ��������� �����������

    private float originalMoveSpeed;
    private bool isAccelerating = false;

    void Start()
    {
        originalMoveSpeed = moveSpeed;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            MoveForward();
        }

        // ��� �����
        if (Input.GetKey(KeyCode.S))
        {
            MoveBackward();
        }

        // ������� ����
        if (Input.GetKey(KeyCode.A))
        {
            RotateLeft();
        }

        // ������� ������
        if (Input.GetKey(KeyCode.D))
        {
            RotateRight();
        }

        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            StartCoroutine(Accelerate());
        }
    }

    IEnumerator Accelerate()
    {
        isAccelerating = true;
        moveSpeed *= accelerationMultiplier;
        yield return new WaitForSeconds(accelerationDuration);
        moveSpeed = originalMoveSpeed;
        isAccelerating = false;
    }

    private void MoveForward()
    {
        if (isAccelerating)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.forward * originalMoveSpeed * Time.deltaTime);
        }
    }

    private void MoveBackward()
    {
        if (isAccelerating)
        {
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(-Vector3.forward * originalMoveSpeed * Time.deltaTime);
        }
    }

    private void RotateLeft()
    {
        transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
    }

    private void RotateRight()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
    }
}
