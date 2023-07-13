using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpMovement : MonoBehaviour
{
    private float speed = 5f;
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
