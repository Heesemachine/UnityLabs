using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pendulumScript : MonoBehaviour
{
    public float amplitude = 45f; // максимальний кут коливанн€
    public float frequency = 1f; // частота коливанн€

    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        // ¬изначенн€ кута коливанн€ на основ≥ часу
        float angle = amplitude * Mathf.Sin(2 * Mathf.PI * frequency * (Time.time - startTime));

        // ќновленн€ обертанн€ ма€тника
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
