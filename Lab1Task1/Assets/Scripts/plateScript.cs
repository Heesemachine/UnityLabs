using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateScript : MonoBehaviour
{
    public float radius = 2f; // ���������� ����� �����
    public float angularSpeed = 1f; // ������ ��������
    public float verticalSpeed = 1f; // ����������� ��������

    private float timeCounter = 0f;

    void Update()
    {
        // ���������� ��������� �� ������������� �������� �����
        float x = radius * Mathf.Cos(timeCounter);
        float y = radius * Mathf.Sin(timeCounter);

        // ��������� ������� ���������
        transform.position = new Vector3(x, y, timeCounter * verticalSpeed);

        // ��������� ����
        timeCounter += Time.deltaTime * angularSpeed;
    }
}
