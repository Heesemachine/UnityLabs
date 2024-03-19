using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

//TASK 1

//Rigidbody - �� ��������� � Unity, ���� ��������������� ��� ����������� ������ ��'����.
//� ���������, ��� ��������� ��������������� ��� ��'����, �� ������ ���������� ������� ������, ����� �� ���������,
//������������ � ������ ��'������, �����������, ��������� ����.
//���� ������ ��������� Rigidbody �� ��'���� � Unity, �� ���������� ���� ��������� � �������� ����� � ��.
//Rigidbody ������� �� ���������� ���� ��'���� � ����������� ����,
//����, ��������, ������ �������� �� ����� �������� ���������.
//���������, ���� �� ������, ��� ��'��� ��������� ���������
//�� �������� � ������ ��'������, ��� �������� ��� ������ ��������� Rigidbody �� ����� ��'����.
//���������� ���� �������� ����� ��'���� � Rigidbody �� ��������� �������,
//�������� ����, �������� ��������, ���������� ����.

public class CarMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // �������� ���� ���������
    public float rotationSpeed = 100f; // �������� �������� ���������


    //TASK 2
    void Start()
    {
        Vector3 vector1 = new Vector3(-1f, 5f, 7f);
        Vector3 vector2 = new Vector3(-2f, 0f, 6f);

        Vector3 crossProduct = Vector3.Cross(vector1, vector2);
        UnityEngine.Debug.Log("��������� �������: " + crossProduct);
    }


    //TASK 3

    void Update()
    {
        // ��� ������
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        // ��� �����
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }

        // ������� ����
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }

        // ������� ������
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}
