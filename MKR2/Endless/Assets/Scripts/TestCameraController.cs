using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class TestCameraController : MonoBehaviour
{
    private Transform player;
    private float yOffset = 2f;
    private float zOffset = -5f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(player.position.x,player.position.y + yOffset,player.position.z+zOffset);
        
    }
}
