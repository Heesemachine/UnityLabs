using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CollisionCounter : MonoBehaviour
{
    private int collisionCount = 0; // ˳������� �������

    // �����������, ���� ��� ��'��� ��������� � �����
    private void OnCollisionEnter(Collision collision)
    {
        // ����������, �� �������� �������� � ���������� (��'��� � ����� "Wall")
        if (collision.gameObject.CompareTag("Cube") && gameObject.CompareTag("Player"))
        {
            // �������� �������� �������
            collisionCount++;

            // ��������� ����������� ������� ������� (�������������� Debug.Log � UnityEngine)
            UnityEngine.Debug.Log("ǳ������ ������ � �����������: " + collisionCount);
        }
    }
}