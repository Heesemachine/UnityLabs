using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public float radius = 2f; // ����� �������
    public float speed = 2f; // �������� ���� ���

    private float timeCounter = 0f;

    void Update()
    {
        // ���������� x �� y �� ������������� �������� �������
        float x = radius * (Mathf.Cos(timeCounter) + timeCounter * Mathf.Sin(timeCounter));
        float y = radius * (Mathf.Sin(timeCounter) - timeCounter * Mathf.Cos(timeCounter));

        // ��������� ������� ���
        transform.position = new Vector3(x, y, 0f);

        // ��������� ����
        timeCounter += Time.deltaTime * speed;
    }
}
