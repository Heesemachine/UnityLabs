using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Domino : MonoBehaviour
{
    [SerializeField] KeyCode keyOne;
    [SerializeField] Vector3 moveDirection;

    private void FixedUpdate()
    {
        if (Input.GetKey(keyOne))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;
        }
    }
}
