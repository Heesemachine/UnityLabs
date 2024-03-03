using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pendulumScript : MonoBehaviour
{
    public float amplitude = 45f; // ������������ ��� ���������
    public float frequency = 1f; // ������� ���������

    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        // ���������� ���� ��������� �� ����� ����
        float angle = amplitude * Mathf.Sin(2 * Mathf.PI * frequency * (Time.time - startTime));

        // ��������� ��������� ��������
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
